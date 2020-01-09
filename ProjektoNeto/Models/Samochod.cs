using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ProjektoNeto.Models
{
    public class Samochod : IValidatableObject
    {
        [ViewData]
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }
        public string Przebieg { get; set; }
        public string Pojemnosc { get; set; }
        public string RodzajPaliwa { get; set; }
        public string Moc { get; set; }
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public string ZdjecieUrl { get; set; }
        public string MiniaturkaUrl { get; set; }
        public bool JestSamochodemTygodnia { get; set; }

        public List<Opinia> Opinie { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            Regex regexMoc = new Regex(@"([0-9])*( )?KM");
            Regex regexPojemnosc = new Regex(@"([0-9])*( )?cm3");
            Regex regexPrzebieg = new Regex(@"([0-9])*( )?km");

            if (!regexMoc.IsMatch(Moc))
            {
                yield return new ValidationResult("To nie jest poprawny zapis mocy", new[] { nameof(Moc) });
            }

            if (!regexPojemnosc.IsMatch(Pojemnosc))
            {
                yield return new ValidationResult("To nie jest poprawny zapis pojemności", new[] { nameof(Pojemnosc) });
            }

            if (!regexPrzebieg.IsMatch(Przebieg))
            {
                yield return new ValidationResult("To nie jest poprawny zapis przebiegu", new[] { nameof(Przebieg) });
            }
        }

    }
}
