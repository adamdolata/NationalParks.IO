using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models.DAL
{
    public interface ISurveyDAL
    {
        IList<SurveyResultModel> GetAllResponses();


        void SaveResponse(SurveyResultModel surveyResponse);
    }
}
