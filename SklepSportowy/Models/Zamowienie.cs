using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepSportowy.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        [Required(ErrorMessage = "Wprowadź imię")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadź adres")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Wprowadź miasto")]
        [StringLength(100)]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadź kod pocztowy")]
        [StringLength(6)]
        public string KodPocztowy { get; set; }
        [Required(ErrorMessage = "Wprowadź numer telefonu")]
        [Phone(ErrorMessage ="Wprowadź porawny numer telefonu")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Wprowadź emial")]
        [EmailAddress(ErrorMessage = "Błędny format adresu email.")]
        public string Email { get; set; }
        public string Uwagi { get; set; }
        public DateTime DataZamowienia { get; set; }
        public StanZamowienia StanZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }
        public List<PozycjaZamowienia> PozycjaZamowienia { get; set; }
    }

    public enum StanZamowienia
    {
        Nowe,
        Zrealizowane
    }
}