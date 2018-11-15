using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.Models;
using Capstone.Web.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Web.Controllers
{
    public class SurveyController : Controller
    {
        private IParkDAL parkDAL;
        private ISurveyDAL surveyDAL;

        public SurveyController(IParkDAL parkDAL, ISurveyDAL surveyDAL)
        {
            this.parkDAL = parkDAL;
            this.surveyDAL = surveyDAL;
        }

        public IActionResult Index()
        {
            var parks = parkDAL.GetAllParks();
            var surveyResults = surveyDAL.GetAllResponses();
            var parkSurveys = (new CombinedParkSurvey(parks, surveyResults));

            return View(parkSurveys);
        }
    }
}