using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models.DAL
{
    public class SurveyDAL : ISurveyDAL
    {
        private readonly string connectionString;

        public SurveyDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
