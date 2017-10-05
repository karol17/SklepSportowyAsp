using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepSportowy.Controllers
{
    public class KoszykController : Controller
    {
        Koszyk koszyk = new Koszyk();
        // GET: Koszyk
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(koszyk.KoszykLinie);
        }
        public ActionResult DodajDoKoszyka(int ilosc, Produkt produkt)
        {
            koszyk.DodajDoKoszyka(ilosc, produkt);
            return View();

        }
        public ActionResult UsunZKoszyka(Produkt produkt)
        {
            koszyk.UsunZKoszyka(produkt);
            return View();
        }
        public String WartoscKoszyka()
        {
            return String.Format("Suma: {0:c2}zł", koszyk.WartoscKoszyka());

        }
        public ActionResult WyczyscKoszyk()
        {
            koszyk.Wyczysc();
            return View();
        }
    }
}