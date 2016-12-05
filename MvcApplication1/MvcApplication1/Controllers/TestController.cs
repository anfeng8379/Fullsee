using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Test_Save()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Test_Save(Register_Model model, string returnUrl)
        {
            //return RedirectToAction("Index");
            return View("aaa");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult abc(Register_Model model, string returnUrl)
        {
            return View("Test_Save");
        }
    }
}
