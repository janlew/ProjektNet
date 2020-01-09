using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjektoNeto.Models;

namespace ProjektoNeto.Controllers
{
    [Authorize]
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository _opiniaRepository;

        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            _opiniaRepository = opiniaRepository;
            
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.SamochodId = new SelectList(_appDbContext.Samochody, "Id");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if (ModelState.IsValid)
            {
                _opiniaRepository.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }
            return View(opinia);
        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}