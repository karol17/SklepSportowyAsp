using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepSportowy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage ="Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string NazwaKategori { get; set; }
        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        [StringLength(500)]
        public string OpisKategorii { get; set; }

        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}