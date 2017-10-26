using SklepSportowy.DAL;
using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepSportowy.Controllers
{
    public class HomeController : Controller
    {
        private ProduktyContext db = new ProduktyContext();
        // GET: Home
        public ActionResult Index()
        {

            return RedirectToAction("List");
        }
        public ActionResult List(int kategoriaId = 0)
        {
            ICollection<Produkt> produkty;
            if (kategoriaId == 0)
                produkty = db.Produkty.ToList();
            else
                produkty = db.Kategorie.Find(kategoriaId).Produkty.ToList();

            return View(produkty);
        }
    }
}