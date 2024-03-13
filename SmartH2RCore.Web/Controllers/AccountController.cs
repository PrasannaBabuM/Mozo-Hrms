
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using SmartH2RCore.Models.DTO;
using SmartH2RCore.Models.DTO.Employee;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Models.Identity;
using SmartH2RCore.Web.Controllers;
using Microsoft.Extensions.Configuration;
using SmartH2RCore.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using AutoMapper.Configuration;


namespace SmartH2RCore.Controllers
{

    public class AccountController : BaseController
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        //private readonly Microsoft.Extensions.Configuration. IConfiguration _iconfiguration;
        //private readonly ILogger _logger;
        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            UserManager<User> usermanager
         /* Microsoft.Extensions.Configuration. IConfiguration iconfiguration*/)
            //ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;

            ////_iconfiguration = iconfiguration;
            //_logger = logger;


        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDTO model, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    //logger.LogInformation("User Logged in successful");
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }

                }
                //TempData["Success"] = false;
                //TempData["Message"] = "Please enter valid email or password";
                //return View(model);
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }




        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

       
        //public string EXAI_Encrypt (string clearText)
        //{
        //    string Encryptionkey = "ADMIN#123";
        //    byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Encryptionkey, new byte[] { 0x49, 0x76, 0x61, 0x20, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms,encryptor.CreateEncryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(clearBytes, 0, clearBytes.Length);
        //                cs.Close();
        //            }
        //            clearText = Convert.ToBase64String(ms.ToArray());
        //        }
        //    }
        //    return clearText;
        //}
        //public string GetUniquekey (int maxSize = 5)
        //{
        //    StringBuilder result = new StringBuilder(maxSize);
        //    try
        //    {
        //        char[] chars = new char[62];
        //        chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        //        byte[] data = new byte[1];
        //        using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
        //        {
        //            crypto.GetNonZeroBytes(data);
        //            data = new byte[maxSize];
        //            crypto.GetNonZeroBytes(data);
        //        }
        //        foreach (byte b in data)
        //        {
        //            result.Append(chars[b % (chars.Length)]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //LOG.(ex.Message,"GetUniqueKey",PageName,1);
        //    }
        //    return result.ToString();
        //}

        //[HttpGet]
        //[AllowAnonymous]
        //public IActionResult Register()
        //{
        //    return View();

        //}

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public IActionResult Register(SignupModel model, string returnUrl = null)
        //{
        //    //string PasswordHash;
        //    //string Passwordsalt;
        //    //PasswordHash = GetUniquekey();
        //    //PasswordHash = EXAI_Encrypt(PasswordHash);
        //    //Passwordsalt = "Admin#123";


        //    ViewData["ReturnUrl"] = returnUrl;
        //    if (ModelState.IsValid)
        //    {
        //        var sing = new SignupModel

        //        {
        //            //UserName = model.Email,
        //            //Email = model.Email,
        //            //PasswordHash = _iconfiguration["Password"]


        //            //PasswordHash = HashPassword(model.Password)
        //            //NormalizedUserName = mdl.NormalizedUserName,
        //            //NormalizedEmail = mdl.NormalizedEmail,
        //            //EmailConfirmed = mdl.EmailConfirmed,
        //            //PasswordHash = mdl.PasswordHash,
        //            //SecurityStamp = mdl.SecurityStamp,
        //            //PhoneNumber = mdl.PhoneNumber,
        //            //PhoneNumberConfirmed = mdl.PhoneNumberConfirmed,
        //            //TwoFactorEnabled = mdl.TwoFactorEnabled,
        //            //LockoutEnabled = mdl.LockoutEnabled,
        //            //AccessFailedCount = mdl.AccessFailedCount,
        //        };

        //        //var passwordHash = _userManager.PasswordHasher.HashPassword(user, model.PasswordHash);
        //        //user.PasswordHash = passwordHash;

              

        //        //if (result.Succeeded)
        //        //{
        //        //    //logger.LogInformation("User created a new account with password.");
        //        //    if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
        //        //    {
        //        //        return RedirectToAction("Index", "Home");
        //        //    }
        //        //    _signInManager.SignInAsync(sing, isPersistent: false);
        //        //    //logger.LogInformation("User created a new account with password");
        //        //    return RedirectToAction("Index", "Home");
        //        //}
        //        //foreach (var errors in result.Errors)
        //        //{
        //        //    ModelState.AddModelError("", errors.Description);
        //        //}
        //        return View(model);
        //    }

        //    //IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
        //    //ModelState.AddModelError(string.Empty, allErrors.FirstOrDefault().ErrorMessage);
        //    return View(model);
        //}

        ////private string HashPassword(string password)
        ////{
        ////    return MyCustomHashFunction(password);
        ////}
        ////private string MyCustomHashFunction(string password)
        ////{
        ////    // Your custom hashing logic goes here
        ////    // This is just a placeholder, you should use a secure hashing algorithm
        ////    return password; // Replace this with your actual hashing logic
        ////}

        [Route("change-password")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Route("change-password"),HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.Password);
            if (!result.Succeeded)
            {
                TempData["Message"] = result.Errors.FirstOrDefault()?.Description;
                TempData["Success"] = false;
                return View();
            }
            TempData["Message"] = "Password Changed Successfully!";
            TempData["Success"] = true;
            return View();
        }
    }

    
}