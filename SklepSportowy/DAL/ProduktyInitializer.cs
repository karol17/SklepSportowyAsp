using SklepSportowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SklepSportowy.DAL
{
    public class ProduktyInitializer:DropCreateDatabaseAlways<ProduktyContext>
    {
        protected override void Seed(ProduktyContext context)
        {
            SeedProduktyData(context);
            base.Seed(context);
        }

        private void SeedProduktyData(ProduktyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaId=1,NazwaKategori="Piłka nożna",OpisKategorii="Kategoria piłka nożna"},
                new Kategoria(){KategoriaId=2,NazwaKategori="Siatkówka",OpisKategorii="Kategoria Siatkóka"},
                new Kategoria(){KategoriaId=3,NazwaKategori="Koszykówka",OpisKategorii="Kategoria koszykówka"},
                new Kategoria(){KategoriaId=4,NazwaKategori="Piłka ręczna",OpisKategorii="Kategoria piłka ręczna"},
                new Kategoria(){KategoriaId=5,NazwaKategori="Tenis",OpisKategorii="Kategoria Tenis"},
                new Kategoria(){KategoriaId=6,NazwaKategori="Kolarstwo",OpisKategorii="Kategoria Kolarstwo"},
                new Kategoria(){KategoriaId=7,NazwaKategori="Pływanie",OpisKategorii="Kategoria pływanie"},
                new Kategoria(){KategoriaId=8,NazwaKategori="Sporty zimowe",OpisKategorii="Kategoria sporty zimowe"},
                new Kategoria(){KategoriaId=9,NazwaKategori="Pozostałe",OpisKategorii="Kategoria Inne"}
            };
            kategorie.ForEach(k => context.Kategorie.Add(k));
            context.SaveChanges();

            var produkty = new List<Produkt>
            {
                new Produkt(){ProduktId=1,NazwaProduktu="Piłka",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat.."
                ,CenaProduktu=59,KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="pilka.jpg"},
                new Produkt(){ProduktId=2,NazwaProduktu="Koszulka",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat. "
                ,CenaProduktu=79,KategoriaId =1,DataDodania=DateTime.Now,Zdjecie="koszulka.jpg"},
                new Produkt(){ProduktId=3,NazwaProduktu="Spodenki",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat.",
                    CenaProduktu =49,KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="spodenki.jpg"},
                new Produkt(){ProduktId=4,NazwaProduktu="Getry",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in e",
                    CenaProduktu =29,KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="getry.jpg"},
                new Produkt(){ProduktId=5,NazwaProduktu="Buty",OpisProduktu="Buty do gry w piłkę nożną",CenaProduktu=189,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="buty.jpg"},
                new Produkt(){ProduktId=6,NazwaProduktu="Piłka",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in e",
                    CenaProduktu =89,KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="pilka2.jpg"},
                new Produkt(){ProduktId=7,NazwaProduktu="Piłka siatkowa",OpisProduktu="Piłka do gry w siatkówkę",CenaProduktu=59,
                KategoriaId=2,DataDodania=DateTime.Now,Zdjecie="pilka-siatka.png"},
                new Produkt(){ProduktId=8,NazwaProduktu="Piłka siatkowa",OpisProduktu="Siatka do gry siatkówkę",CenaProduktu=49,
                KategoriaId=2,DataDodania=DateTime.Now,Zdjecie="pilka-siatka1.jpg"},
                new Produkt(){ProduktId=9,NazwaProduktu="Rakiata do tenisa",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat. ."
                ,CenaProduktu=139,KategoriaId=5,DataDodania=DateTime.Now,Zdjecie="rakieta.jpg"},
                new Produkt(){ProduktId=10,NazwaProduktu="Rower",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=59,KategoriaId=6,DataDodania=DateTime.Now,Zdjecie="rower.jpg"},
                new Produkt(){ProduktId=11,NazwaProduktu="Narty",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=199,KategoriaId=8,DataDodania=DateTime.Now,Zdjecie="narty.jpg"},
                new Produkt(){ProduktId=12,NazwaProduktu="Deska snowbordowa",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=250,KategoriaId=8,DataDodania=DateTime.Now,Zdjecie="deska.jpg"},
                new Produkt(){ProduktId=13,NazwaProduktu="Piłka do tenisa",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat. ."
                ,CenaProduktu=10,KategoriaId=5,DataDodania=DateTime.Now,Zdjecie="pilka-tenis.jpg"},
                new Produkt(){ProduktId=14,NazwaProduktu="Kask",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=59,KategoriaId=6,DataDodania=DateTime.Now,Zdjecie="kask.jpg"},
                new Produkt(){ProduktId=15,NazwaProduktu="Piłka do kosza",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=79,KategoriaId=3,DataDodania=DateTime.Now,Zdjecie="pilka-kosz.jpg"},
                new Produkt(){ProduktId=16,NazwaProduktu="Piłka do kosza",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=74,KategoriaId=3,DataDodania=DateTime.Now,Zdjecie="pilka-kosz1.jpg"},
                new Produkt(){ProduktId=17,NazwaProduktu="Piłka siatkowa",OpisProduktu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam interdum dolor eu consectetur. Aenean in eros in elit porttitor sodales ut vitae neque. Pellentesque consectetur turpis mi, vel viverra diam dapibus et. In tempor odio sed tellus accumsan feugiat."
                ,CenaProduktu=88,KategoriaId=2,DataDodania=DateTime.Now,Zdjecie="pilka-siatka2.jpg"}
            };
            produkty.ForEach(p => context.Produkty.Add(p));
            context.SaveChanges();
        }
    }
}