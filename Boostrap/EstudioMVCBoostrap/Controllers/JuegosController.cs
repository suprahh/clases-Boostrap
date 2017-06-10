using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudioMVCBoostrap.Controllers
{
    public class JuegosController : Controller
    {
        // GET: Juegos
        public ActionResult Index()
        {
            return View();
        }
    }
}