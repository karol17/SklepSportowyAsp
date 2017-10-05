using SklepSportowy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepSportowy.Models
{
    public class Koszyk : IOrdeable
    {
       private List<KoszykLinia> zamowienia=new List<KoszykLinia>();
        public void DodajDoKoszyka(int ilosc,Produkt produkt)
        {
            KoszykLinia koszykLinia=zamowienia.Where(p=>p.Produkt.ProduktId==produkt.ProduktId).FirstOrDefault();
            if (koszykLinia == null)
            {
                zamowienia.Add(new KoszykLinia
                {
                    Produkt = produkt,
                    Ilosc = ilosc
                });
            }
            else
                koszykLinia.Ilosc += ilosc;
           
        }

       
        public void UsunZKoszyka(Produkt produkt)
        {
            zamowienia.RemoveAll(p => p.Produkt.ProduktId == produkt.ProduktId);
        }

        public decimal WartoscKoszyka()
        {
            return zamowienia.Sum(p => p.Produkt.CenaProduktu * p.Ilosc);

        }
        public void Wyczysc()
        {
            zamowienia.Clear();
        }
        public IEnumerable<KoszykLinia> KoszykLinie
        {
            get{ return zamowienia; }
        }
    }
    public class KoszykLinia
    {
        public Produkt Produkt { get; set; }
        public int Ilosc { get; set; }
    }
}