using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Capstone.Web.Models;
using Capstone.Web.Models.DAL;

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

        public IActionResult Index()
        {
            IList<ParkDataModel> parks = parkDAL.GetAllParks();
            return View(parks);
        }

        public IActionResult ParkDetails(string parkCode)
        {
            var park = parkDAL.GetParkFromCode(parkCode);
            var weather = weatherDAL.GetWeatherFromParkCode(parkCode);

            var parkWeather = (new CombinedParkWeather(park, weather)).GetParkWeather();

            return View(parkWeather);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
