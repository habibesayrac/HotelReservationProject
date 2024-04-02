﻿using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel userEditViewModel = new UserEditViewModel();

            userEditViewModel.Name = "Ayşe";
            userEditViewModel.Surname = "Yıldız";
            userEditViewModel.Username = "ayse01";
            userEditViewModel.Email = "deneme1@mail.com";

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            //if (userEditViewModel.Password == userEditViewModel.ConfirmPassword)
            //{

            //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //    user.Name = userEditViewModel.Name;
            //    user.Surname = userEditViewModel.Surname;
            //    user.Email = userEditViewModel.Email;
            //    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            //    await _userManager.UpdateAsync(user);
            //    return RedirectToAction("Index", "Login");
            //}
            return View();
        }

    }
}
