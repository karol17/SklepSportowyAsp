using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepSportowy.Models
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage ="Wprowadź nazwę produktu")]
        [StringLength(100)]
        public string NazwaProduktu { get; set; }
        [Required(ErrorMessage ="Wprowadź opis produktu")]
        
        public string OpisProduktu { get; set; }
        [StringLength(100)]
        public string Zdjecie { get; set; }
        public DateTime DataDodania { get; set; }
        public decimal CenaProduktu { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}