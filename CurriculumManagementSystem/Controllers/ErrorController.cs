﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurriculumManagementSystem.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Error404()
        {
            return View();
        }
    }
}