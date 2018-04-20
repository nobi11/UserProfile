﻿using System;
using Microsoft.AspNetCore.Mvc;
using UserProfile.Models;

namespace UserProfile.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDetails()
        {
            UserDataModel umodel = new UserDataModel();
            umodel.Name = HttpContext.Request.Form["txtName"].ToString();
            umodel.Age = Convert.ToInt32(HttpContext.Request.Form["txtAge"]);
            umodel.City = HttpContext.Request.Form["txtCity"].ToString();

            int result = umodel.SaveDetails();
            if (result > 0)
            {
                ViewBag.Result = "Data Saved Successfully";
            }
            else
            {
                ViewBag.Result = "Something Went Wrong";
            }
            return View("Profile");
        }
    }
}
