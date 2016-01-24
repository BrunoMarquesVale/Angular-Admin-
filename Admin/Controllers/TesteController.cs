using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class TesteController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("Teste");
        }

        public ActionResult Teste()
        {
            ViewBag.Title = "Teste Page";

            return View();
        }
    }
}
