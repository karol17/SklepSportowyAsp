using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepSportowy.ViewModel
{
    public class KoszykUsunViewModel
    {
        public int UsunProduktId { get; set; }
        public decimal KoszykCenaCalkowita { get; set; }
        public int IloscUsuwanychProdutkow{ get; set; }
        public int KoszykIlosc { get; set; }
    }
}