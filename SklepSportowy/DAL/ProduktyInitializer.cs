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
                new Kategoria(){KategoriaId=9,NazwaKategori="Inne",OpisKategorii="Kategoria Inne"}
            };
            kategorie.ForEach(k => context.Kategorie.Add(k));
            context.SaveChanges();

            var produkty = new List<Produkt>
            {
                new Produkt(){ProduktId=1,NazwaProduktu="Piłka",OpisProduktu="Piłka do gry w piłkę nożną",CenaProduktu=59,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="pilka.jpg"},
                new Produkt(){ProduktId=2,NazwaProduktu="Koszulka",OpisProduktu="Koszulka do gry w piłkę nożną",CenaProduktu=79,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="koszulka.jpg"},
                new Produkt(){ProduktId=3,NazwaProduktu="Spodenki",OpisProduktu="Spodenki do gry w piłkę nożną",CenaProduktu=49,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="pilka.jpg"},
                new Produkt(){ProduktId=4,NazwaProduktu="Getry",OpisProduktu="Getry do gry w piłkę nożną",CenaProduktu=29,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="getry.jpg"},
                new Produkt(){ProduktId=5,NazwaProduktu="Buty",OpisProduktu="Buty do gry w piłkę nożną",CenaProduktu=189,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="buty.jpg"},
                new Produkt(){ProduktId=6,NazwaProduktu="Ochraniacze",OpisProduktu="Ochraniacze do gry w piłkę nożną",CenaProduktu=39,
                KategoriaId=1,DataDodania=DateTime.Now,Zdjecie="ochraniacze.jpg"},
                new Produkt(){ProduktId=7,NazwaProduktu="Piłka siatkowa",OpisProduktu="Piłka do gry w siatkówkę",CenaProduktu=59,
                KategoriaId=2,DataDodania=DateTime.Now,Zdjecie="pilka-siatkowa.jpg"},
                new Produkt(){ProduktId=8,NazwaProduktu="Siatka",OpisProduktu="Siatka do gry siatkówkę",CenaProduktu=49,
                KategoriaId=2,DataDodania=DateTime.Now,Zdjecie="siatka.jpg"}
            };
            produkty.ForEach(p => context.Produkty.Add(p));
            context.SaveChanges();
        }
    }
}