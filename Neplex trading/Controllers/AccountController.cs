using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Neplex_trading.ViewModels;

namespace Neplex_trading.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost][HttpGet]
        public async Task<IActionResult> UniqueEmail(string email) 
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already taken.");
            }
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            { 
             var user = new IdentityUser{ UserName = model.Name,
                                          Email = model.Email,
                                          PhoneNumber = model.PhoneNumber
                                        };
             var result =  await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                  await  _signInManager.SignInAsync(user, isPersistent: true);
                    return RedirectToAction("Index","Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
         

            return View(new LoginVM { ReturnUrl= returnUrl});
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            IdentityUser user;
            if (ModelState.IsValid) 
            {
                if (model.Email.Contains("@"))
                {
                    user = await _userManager.FindByEmailAsync(model.Email);
                }else
                {
                    user = await _userManager.FindByNameAsync(model.Email);
                }

                var result = await _signInManager.PasswordSignInAsync(user.UserName,model.Password,model.RememberMe,false);

                if (result.Succeeded)
                {
                    if (model.ReturnUrl != null && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl );
                    }
                    else
                    {
                        return RedirectToAction("index", "Home");

                    }
                }

                ModelState.AddModelError("", "Invalid login attempt");

              
            }

            return View(model);
        }




        public IActionResult AccessDenied()
        {
            return View();
        }






        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}