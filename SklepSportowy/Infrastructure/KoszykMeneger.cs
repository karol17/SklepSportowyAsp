using SklepSportowy.DAL;
using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepSportowy.Infrastructure
{
    public class KoszykMeneger
    {
        private ProduktyContext db;
        private ISessionMeneger session;
        public KoszykMeneger(ISessionMeneger session,ProduktyContext db)
        {
            this.session = session;
            this.db = db;
        }
        public List<PozycjaKoszyka> PobierzKoszyk()
        {
            List<PozycjaKoszyka> koszyk;
            if (session.Get<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz) == null)
                koszyk = new List<PozycjaKoszyka>();
            else
            {
                koszyk = session.Get<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz) as List<PozycjaKoszyka>;
            }
            return koszyk;
        }
        public void DodajDoKoszuka(int produktId)
        {
            var koszyk = PobierzKoszyk();
            var pozycjaKoszyka = koszyk.Find(k => k.Produkt.ProduktId == produktId);
            if (pozycjaKoszyka != null)
            {
                pozycjaKoszyka.Ilosc++;
            }
            else
            {
                var produktDoDodania = db.Produkty.Where(p => p.ProduktId == produktId).SingleOrDefault();
                if (produktDoDodania != null)
                {
                    var nowaPozycjaKoszyka = new PozycjaKoszyka()
                    {
                        Produkt = produktDoDodania,
                        Ilosc = 1,
                        Wartosc = produktDoDodania.CenaProduktu
                    };
                    koszyk.Add(nowaPozycjaKoszyka);
                }


            }
            session.Set(Consts.KoszykSessionKlucz, koszyk);
        }
        public int UsunZKoszyka(int produktId)
        {
            var koszyk = PobierzKoszyk();
            var pozycjaKoszyka = koszyk.Find(p => p.Produkt.ProduktId == produktId);
            if (pozycjaKoszyka != null)
            {
                if (pozycjaKoszyka.Ilosc > 1)
                {
                    pozycjaKoszyka.Ilosc--;
                    return pozycjaKoszyka.Ilosc;
                }
                else
                {
                    koszyk.Remove(pozycjaKoszyka);
                    
                }
            }
            return 0;
        }
        public decimal PobierzWartoscKoszyka()
        {
            var koszyk = PobierzKoszyk();
            return koszyk.Sum(p => p.Produkt.CenaProduktu * p.Ilosc);   
        }
        public int PobierzIloscPozycjiKoszyka()
        {
            var koszyk = PobierzKoszyk();
            int ilosc = koszyk.Sum(k => k.Ilosc);
            return ilosc;
        }
        public Zamowienie UtworzZamowienie(Zamowienie zamowienie)
        {
            var koszyk = PobierzKoszyk();
            zamowienie.DataZamowienia = DateTime.Now;
            
            db.Zamowienia.Add(zamowienie);

            if (zamowienie.PozycjaZamowienia == null)
                zamowienie.PozycjaZamowienia = new List<PozycjaZamowienia>();
            decimal koszykWartosc = 0;
            foreach(var item in koszyk)
            {
                var nowaPozycjaZamowienia = new PozycjaZamowienia()
                {
                    ProduktId = item.Produkt.ProduktId,
                    Ilosc = item.Ilosc,
                    CenaZakupu = item.Produkt.CenaProduktu
                };
                koszykWartosc += (item.Ilosc * item.Produkt.CenaProduktu);
                zamowienie.PozycjaZamowienia.Add(nowaPozycjaZamowienia);
            }
            zamowienie.WartoscZamowienia = koszykWartosc;

            db.SaveChanges();
            return zamowienie;
        }
        public void WyczyscKoszyk()
        {
            session.Set<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz, null);
        }
       
    }
}