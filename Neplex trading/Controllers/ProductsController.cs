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
using ReflectionIT.Mvc.Paging;

namespace Neplex_trading.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hostingEnv;

        public ProductsController(AppDbContext context,IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnv = hostingEnvironment;
        }


        public IActionResult AdminIndex() {
           var products= _context.Products.Include(c=>c.Category);
            return View(products);
        }

        public IActionResult ProductSearch(string searcheditem)
        {
            var query = from x in _context.Products select x;
            if (!String.IsNullOrEmpty(searcheditem))
            {
                query = query.Where(x => x.ProductName.Contains(searcheditem));
            }

            if (query.Any())
                return View(query.AsNoTracking().ToList());
            
            return View("NotFound");

        }

        // GET: Products
        [Obsolete]
        public async Task<IActionResult> Index(int  page=1)
        {
            var item = _context.Products.AsNoTracking().OrderBy(p => p.ProductName);
            var model = await PagingList<Product>.CreateAsync(item,12,page);
          
            ViewBag.category = _context.Categories;
           
            return View(model);
        }

        // GET: Products/Details/5
        public  IActionResult Details(int? id)
        {
            Product product = _context.Products.Find(id);
            if(product==null)
            {
                return View("NotFound");
            }
           
            var relproducts = _context.Products.Where(p => p.CategoryId == product.CategoryId).ToList();

            if (product == null)
            {
                return View("NotFound");
            }

            DetailsProductVM model = new DetailsProductVM {
            
            Product = product,
            RelatedProducts = relproducts
            };


            return View(model);
        }





        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CartegoryId", "Name");
            return View();
        }

       

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(ProductsVM model)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Photo != null)
                {
                    string uploadFolder = Path.Combine(_hostingEnv.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Product newProduct = new Product
                {
                    ProductName = model.ProductName,
                    ProductImage = uniqueFileName,
                    ProductArtNumber= model.ProductArtNumber,
                    ProductDescription = model.ProductDescription,
                    CategoryId = model.CategoryId
                };
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CartegoryId", "Name", model.CategoryId);


                _context.Products.Add(newProduct);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);

        }




        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            EditProductVM editProductVM = new EditProductVM { 
                
                ProductId=product.ProductId,
                ProductName= product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductArtNumber = product.ProductArtNumber,
                ExistingPhoto = product.ProductImage,
                IsFeatured = product.IsFeatured,
                InStock = product.InStock,
                CategoryId = product.CategoryId

            };

            ViewData["CategoryId"] = new SelectList(_context.Categories, "CartegoryId", "Name", product.CategoryId);
            return View(editProductVM);
        }




        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditProductVM model)
        {
            Product product = _context.Products.Find(model.ProductId);
            if (product == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (model.Photo != null)
                {
                    if (model.ExistingPhoto != null)
                    {
                        string filePath = Path.Combine(_hostingEnv.WebRootPath,
                            "img", model.ExistingPhoto);
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

                        product.ProductImage = uniqueFileName;

                    }

                }
                        product.ProductName = model.ProductName;
                        product.ProductArtNumber = model.ProductArtNumber;
                        product.ProductDescription = model.ProductDescription;
                        product.CategoryId = model.CategoryId;
                        product.Price = model.Price;
                        product.IsFeatured = model.IsFeatured;
                        product.InStock = model.InStock;
                    
                    ViewData["CategoryId"] = new SelectList(_context.Categories, "CartegoryId", "Name", model.CategoryId);


                    _context.Products.Update(product);
                    _context.SaveChanges();

                    return RedirectToAction("Index");

                
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CartegoryId", "Name", model.CategoryId);
            return View(model);
        }





        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }





        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
