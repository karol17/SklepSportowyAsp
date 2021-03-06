﻿using SklepSportowy.DAL;
using SklepSportowy.Infrastructure;
using SklepSportowy.Models;
using SklepSportowy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepSportowy.Controllers
{
    public class KoszykController : Controller
    {
        private ISessionMeneger session { get; set; }
        private KoszykMeneger koszyk;
        private ProduktyContext db;

        public KoszykController()
        {
            db = new ProduktyContext();
            session = new SessionMeneger();
            koszyk = new KoszykMeneger(session, db);
        }
        
        // GET: Koszyk
        
        public ActionResult Index()
        {
            KoszykViewModel vm = new KoszykViewModel()
            {
                PozycjaKoszyka = koszyk.PobierzKoszyk(),
                WartoscKoszyka = koszyk.PobierzWartoscKoszyka()
            };
            return View(vm);
        }
        
        public ActionResult DodajDoKoszyka( int id)
        {
            koszyk.DodajDoKoszuka(id);
            return RedirectToAction("Index");

        }
        public ActionResult UsunZKoszyka(int produktId)
        {
            int iloscPozycji = koszyk.UsunZKoszyka(produktId);
            KoszykUsunViewModel vm = new KoszykUsunViewModel()
            {
                UsunProduktId = produktId,
                KoszykCenaCalkowita = koszyk.PobierzWartoscKoszyka(),
                KoszykIlosc = koszyk.PobierzIloscPozycjiKoszyka(),
                IloscUsuwanychProdutkow = iloscPozycji
            };
            return Json(vm);
        }
        public String WartoscKoszyka()
        {
            var sum=db.PozycjeZamowien.Sum(p => p.produkt.CenaProduktu * p.Ilosc);
            return String.Format("Suma: {0:c2}zł", sum);

        }
        public ActionResult Zaplac()
        {
            return View( new Zamowienie());
        }
        [HttpPost]
        public ActionResult Zaplac(Zamowienie zamowienie)
        {
            if (ModelState.IsValid)
            {
                var noweZamowienie = koszyk.UtworzZamowienie(zamowienie);
                koszyk.WyczyscKoszyk();
                return RedirectToAction("PotwierdzenieZamowienia");
            }
            return View(zamowienie);
        }
        public ActionResult PotwierdzenieZamowienia()
        {
            return View();
        }


    }
}