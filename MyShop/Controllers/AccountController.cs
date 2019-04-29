﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyShop.Controllers
{

        public class AccountController : Controller
        {
            private UserManager<ApplicationUser> _userManager;
            private SignInManager<ApplicationUser> _signInManager;


            public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
            {
                _userManager = userManager;
                _signInManager = signInManager;
            }

            [HttpGet]
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Register(RegisterViewModel rvm)
            {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Email = rvm.Email,
                    UserName = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    Birthday = rvm.Birthday
                };
                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    Claim nameClaim = new Claim("FullName", $"{user.FirstName} { user.LastName} ");

                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    Claim dateOfBirthClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"), ClaimValueTypes.DateTime);

                    List<Claim> claims = new List<Claim> { nameClaim, emailClaim, dateOfBirthClaim };
                    await _userManager.AddClaimsAsync(user, claims);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    RedirectToAction("Index", "Home");
                }
            }
            return View(rvm);
                
            }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(lvm);
            {

            }
        }
        }
}
