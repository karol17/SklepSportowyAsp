using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace SklepSportowy.DAL
{
    public class ProduktyContext : DbContext
    {
       public ProduktyContext() : base("ProduktyContext")
        {

        }
        static ProduktyContext()
        {
            Database.SetInitializer<ProduktyContext>(new ProduktyInitializer());
        }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowien { get; set; }
    }
}