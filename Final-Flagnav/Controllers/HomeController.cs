using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_Flagnav.Models;
using System.Data.Entity;

namespace Final_Flagnav.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var db = new modeEntities())
            {
                var d = db.MainMenus.Include(c => c.SubMenus).ToList();
                return View(d);
            }
        }
    }
}