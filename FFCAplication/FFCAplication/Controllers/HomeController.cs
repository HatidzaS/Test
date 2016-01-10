using FFCAplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFCAplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        MojContext ctx = new MojContext();
        public ActionResult Index()
        {
            ctx.Korisnici.Find(0);
            return View();
        }
    }
}