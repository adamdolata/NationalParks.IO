using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class CombinedParkSurvey
    {
        private IList<ParkDataModel> parks;
        private IList<SurveyResultModel> surveyResults;

        public CombinedParkSurvey(IList<ParkDataModel> parks, IList<SurveyResultModel> surveyResults)
        {
            this.surveyResults = surveyResults;
            this.parks = parks;
        }

        public Dictionary<string, Object> GetParkSurvey()
        {
            Dictionary<string, object> lst = new Dictionary<string, object>();
            lst.Add("parks", parks);
            lst.Add("surveyResults", surveyResults);

            return lst;
        }
    }
}
