using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektoNeto.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Samochody.Any())
            {
                context.AddRange(
                    new Samochod { Marka = "Ford", Model = "Mustang", RokProdukcji = 2016, Przebieg = "34 000 km", Pojemnosc = "4 900 cm3", RodzajPaliwa = "benzyna", Moc = "421 KM", Opis = "Ford Mustang opis", Cena = 160000M, ZdjecieUrl = "/images/fordMustang.jpg", MiniaturkaUrl = "/images/fordMustang.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Audi", Model = "S5", RokProdukcji = 2013, Przebieg = "112 000 km", Pojemnosc = "3 000 cm3", RodzajPaliwa = "benzyna", Moc = "280 KM", Opis = "Audi S5 opis", Cena = 115000M, ZdjecieUrl = "/images/audiS5.jpg", MiniaturkaUrl = "/images/audiS5.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "BMW", Model = "X4", RokProdukcji = 2017, Przebieg = "4 300 km", Pojemnosc = "1 995 cm3", RodzajPaliwa = "benzyna", Moc = "190 KM", Opis = "BMW X4 opis", Cena = 194000M, ZdjecieUrl = "/images/bmvx4.jpg", MiniaturkaUrl = "/images/bmvx4.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Chevrolet", Model = "Corvette", RokProdukcji = 1972, Przebieg = "28 000 km", Pojemnosc = "5 700 cm3", RodzajPaliwa = "benzyna", Moc = "300 KM", Opis = "Chevrolet Corvetta opis", Cena = 90000M, ZdjecieUrl = "/images/chevroletCorvete.jpg", MiniaturkaUrl = "/images/chevroletCorvete.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Nissan", Model = "Skyline", RokProdukcji = 1995, Przebieg = "144 000 km", Pojemnosc = "2 500 cm3", RodzajPaliwa = "benzyna", Moc = "410 KM", Opis = "Nissan Skyline opis", Cena = 120000M, ZdjecieUrl = "/images/nissan.jpg", MiniaturkaUrl = "/images/nissan.jpg", JestSamochodemTygodnia = true },
                    new Samochod { Marka = "Jaguar", Model = "ZX", RokProdukcji = 2006, Przebieg = "78000 km", Pojemnosc = "5 000 cm3", RodzajPaliwa = "benzyna", Moc = "510 KM", Opis = "Jaguar ZX opis", Cena = 200000M, ZdjecieUrl = "/images/jaguar.jpg", MiniaturkaUrl = "/images/jaguar.jpg", JestSamochodemTygodnia = true }
                    );
            }
            context.SaveChanges();
        }
    }
}
