using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Capstone.Web.Models;
using Capstone.Web.Models.DAL;
using Capstone.Web.Extensions;

namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        private IParkDAL parkDAL;
        private IWeatherDAL weatherDAL;

        public HomeController(IParkDAL parkDAL, IWeatherDAL weatherDAL)
        {
            this.parkDAL = parkDAL;
            this.weatherDAL = weatherDAL;
        }

        private void SaveTempUnits(string tempUnits)
        {
            HttpContext.Session.Set<string>("TempUnits", tempUnits);
        }

        private string GetTempUnits()
        {
            if (HttpContext.Session.Get<string>("TempUnits") == null)
            {
                HttpContext.Session.Set<string>("TempUnits", "F");
            }
            return HttpContext.Session.Get<string>("TempUnits");
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<ParkDataModel> parks = parkDAL.GetAllParks();
            return View(parks);
        }

        [HttpGet]
        public IActionResult ParkDetails(string parkCode)
        {
            var park = parkDAL.GetParkFromCode(parkCode);
            var weather = weatherDAL.GetWeatherFromParkCode(parkCode);
            var tempUnits = GetTempUnits();
            var parkWeather = (new CombinedParkWeather(park, weather, tempUnits));

            return View(parkWeather);
        }

        [HttpGet]
        public IActionResult SetTempUnits(string tempUnits, string parkCode)
        {
            SaveTempUnits(tempUnits);

            //weatherDAL.TempUnits = tempUnits;
            return RedirectToAction("ParkDetails", new { parkCode = parkCode });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
