using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.Models;
using Capstone.Web.Models.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var parksList = parkDAL.GetParksSelectList();
            var parkSurveys = new CombinedParkSurvey(parks, surveyResults, parksList);
            return View(parkSurveys);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveSurveyResponse(SurveyResultModel response)
        {
            surveyDAL.SaveResponse(response);

            return RedirectToAction("Index");
        }



    }
}