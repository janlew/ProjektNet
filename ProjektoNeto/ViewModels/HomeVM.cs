using Microsoft.AspNetCore.Mvc;
using ProjektoNeto.Models;
using System.Collections.Generic;

namespace ProjektoNeto.ViewModels
{
    public class HomeVM
    {
        [ViewData]
        public string Tytul { get; set; }
        public List<Samochod> Samochody { get; set; }
    }
}
