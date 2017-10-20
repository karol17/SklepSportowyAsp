using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepSportowy.ViewModel
{
    public class KoszykViewModel
    {
        public List<PozycjaKoszyka>  PozycjaKoszyka { get; set; }
        public decimal WartoscKoszyka { get; set; }
    }
}