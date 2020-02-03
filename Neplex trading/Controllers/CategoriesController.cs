using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Neplex_trading.Data;
using Neplex_trading.Models;
using Neplex_trading.ViewModels;

namespace Neplex_trading.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnv;

        public CategoriesController(AppDbContext context,IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnv = hostingEnvironment;
        }

        // GET: Categories
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CartegoryId == id);
            if (category == null)
            {
                return View("NotFound");
            }

            return View(category);
        }
        [Authorize(Roles ="Admin")]
        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category newCategory = new Category
                {
                    Name = model.Name
                };
                if (model.Photo != null) {
                    newCategory.ImagePath = ProcessUploadedFile(model);
                }

            

                _context.Categories.Add(newCategory);
                _context.SaveChanges();

                return RedirectToAction("Index");
              
            }
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return View("NotFound");
            }
            EditCategoryVM editCategoryVM = new EditCategoryVM { 
                Id = category.CartegoryId,
                ExsistingPhoto = category.ImagePath,
                Name = category.Name
            };
            return View(editCategoryVM);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // EmployeeEditViewModel receives the posted edit form data
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(EditCategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category  category= _context.Categories.Find(model.Id);
                if (category == null)
                    return NotFound();
                category.Name = model.Name;

                if (model.Photo != null)
                {
                    if (model.ExsistingPhoto != null)
                    {
                        string filePath = Path.Combine(_hostingEnv.WebRootPath,
                            "img", model.ExsistingPhoto);
                        System.IO.File.Delete(filePath);
                    }

                    string uniqueFileName = null;

                    if (model.Photo != null)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnv.WebRootPath, "img");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            model.Photo.CopyTo(fileStream);
                        }
                    }

                    category.ImagePath= uniqueFileName;

                }

                _context.Categories.Update(category);
                _context.SaveChanges();
                return RedirectToAction("index");
            }

            return View(model);
        }

        private string ProcessUploadedFile(CategoryVM model)
        {
            string uniqueFileName = null;

            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnv.WebRootPath, "img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        // GET: Categories/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CartegoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ProductByCategory(int id) {
            
            var products = _context.Products.Where(p => p.CategoryId == id).ToList();
            var categoryName = _context.Categories.Single(c => c.CartegoryId == id);
         
            
            ProductByCategoryVM model = new ProductByCategoryVM {
            Products = _context.Products,
            SingleProductList = products,
            Categories = _context.Categories,
            CategoryName = categoryName.Name
            };
            
            return View(model);
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CartegoryId == id);
        }
    }
}
