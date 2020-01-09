using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ProjektoNeto.Models
{
    public class Opinia : IValidatableObject
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        public string NazwaUzytkownika { get; set; }
       
        public string Email { get; set; }

        [Required(ErrorMessage = "Wiadomość jest wymagana")]
        [StringLength(5000, ErrorMessage = "Wiadomość jest za długa")]
        public string Wiadomosc { get; set; }

        [Required(ErrorMessage = "Id jest wymagane")]
        public int SamochodId { get; set; }

        public Samochod Samochod { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            Regex regex = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");
            if (!regex.IsMatch(Email))
            {
                yield return new ValidationResult("To nie jest poprawny adres email.", new[] { nameof(Email) });
            }

            if (NazwaUzytkownika.Length < 2 || NazwaUzytkownika.Length > 100)
            {
                yield return new ValidationResult("Nazwa użytkownika nieprawidłowa", new[] { nameof(NazwaUzytkownika) });
            }

            if (SamochodId < 0)
            {
                yield return new ValidationResult("Id nie może być liczbą ujemną", new[] { nameof(SamochodId) });
            }

            
        }

    }
}
