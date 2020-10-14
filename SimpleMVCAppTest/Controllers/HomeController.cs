using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SimpleMVCAppTest.ApplicationService.Interfaces;
using SimpleMVCAppTest.Models;
using SimpleMVCAppTest.ViewModel;

namespace SimpleMVCAppTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICountryAppService countryAppService;
        private readonly IAnimalAppService animalAppService;
        private HomeViewModel homeViewModel;

        public HomeController(ILogger<HomeController> logger,
                              ICountryAppService countryAppService,
                              IAnimalAppService animalAppService)
        {
            _logger = logger;
            this.countryAppService = countryAppService;
            this.animalAppService = animalAppService;
        }

        public IActionResult Index()
        {
            homeViewModel = new HomeViewModel();
            homeViewModel.countries = countryAppService.GetCountries();
            return View(homeViewModel);
        }

        [HttpPost]  
        public JsonResult GetAnimalByCountry(string country)
        {
            var animals = animalAppService.GetAnimalByCountryCode(country);
            return Json(animals);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
