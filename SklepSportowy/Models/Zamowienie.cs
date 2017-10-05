﻿using System;
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
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wprowadź miasto")]
        [StringLength(100)]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadź imię")]
        [StringLength(6)]
        public string KodPocztowy { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Komentarz { get; set; }
        public DateTime DataZamowienia { get; set; }
        public StanZamowienia StanZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }
        List<PozycjaZamowienia> PozycjaZamowienia { get; set; }
    }

    public enum StanZamowienia
    {
        Nowe,
        Zrealizowane
    }
}