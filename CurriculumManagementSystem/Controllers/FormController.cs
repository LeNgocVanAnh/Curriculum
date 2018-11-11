using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurriculumManagementSystem.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult FormCommon()
        {
            return View();
        }
        public ActionResult FormValidation()
        {
            return View();
        }
        public ActionResult FormWizard()
        {
            return View();
        }
    }
}