using SklepSportowy.DAL;
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
        //Koszyk koszyk = new Koszyk();
        // GET: Koszyk
        ProduktyContext db = new ProduktyContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(db.PozycjeZamowien.ToList());
        }
        public ActionResult DodajDoKoszyka( Produkt produkt, int ilosc=1)
        {
            
            

            
            PozycjaZamowienia zamowienie = db.PozycjeZamowien.Where(z => z.ProduktId == produkt.ProduktId).FirstOrDefault();
            if (zamowienie == null)
            {
                db.PozycjeZamowien.Add(new PozycjaZamowienia
                {

                    ProduktId = produkt.ProduktId,
                    Ilosc = ilosc
                });
            }
            else
                zamowienie.Ilosc += ilosc;
            
           

            db.SaveChanges();
            //koszyk.DodajDoKoszyka(ilosc, produkt);
            return RedirectToAction("List");

        }
        public ActionResult UsunZKoszyka(Produkt produkt)
        {
            var zamowienie = db.PozycjeZamowien.Where(p => p.ProduktId == produkt.ProduktId).FirstOrDefault();
            db.PozycjeZamowien.Remove(zamowienie);
            return View("List");
        }
        public String WartoscKoszyka()
        {
            var sum=db.PozycjeZamowien.Sum(p => p.produkt.CenaProduktu * p.Ilosc);
            return String.Format("Suma: {0:c2}zł", sum);

        }
        public ActionResult WyczyscKoszyk()
        {
            var zamowienia = db.PozycjeZamowien;
            for(int i = zamowienia.Count() - 1; i == 0; i--)
            {
                zamowienia.Remove(zamowienia.Where(z => z.PozycjaZamowieniaId == i).FirstOrDefault());
            }
            return View("List");
        }
    }
}