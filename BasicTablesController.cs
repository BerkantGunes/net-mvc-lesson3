using CAR.ADMIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAR.ADMIN.Controllers
{
    public class BasicTablesController : Controller
    {
        private AppDbContext db = new AppDbContext();
        // GET: BasicTables
        public ActionResult Index()
        {
            var ogrenciler = db.Ogrenci.ToList();
            return View(ogrenciler);
        }
    }
}