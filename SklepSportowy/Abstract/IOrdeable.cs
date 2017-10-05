using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepSportowy.Abstract
{
    interface IOrdeable
    {
        void DodajDoKoszyka(int ilosc,Produkt produkt);
        void UsunZKoszyka(Produkt produkt); 
        decimal WartoscKoszyka();
        void Wyczysc();
    }
}
