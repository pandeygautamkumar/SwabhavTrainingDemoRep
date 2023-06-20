﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVCApp.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            HttpContext.Application["Counter"] = (int)HttpContext.Application["Counter"] + 1;
            return View();
        }
    }
}