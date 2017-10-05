using SklepSportowy.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepSportowy.Controllers
{
    public class ProduktController : Controller
    {
        private ProduktyContext db=new ProduktyContext();
        // GET: Produkt
        public ActionResult ProduktSzczegoly(int id)
        {
            var produkt=db.Produkty.Find(id);
            return View(produkt);
        }
    }
}