﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
