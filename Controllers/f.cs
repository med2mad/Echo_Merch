﻿using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Controllers
{
    public class f : Controller
    {
        public IActionResult Index()
        {
            return Content("");
        }

        public IActionResult xxl()
        {
            return View();
        }

    }
}
