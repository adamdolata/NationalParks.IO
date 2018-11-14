using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models.DAL
{
    public interface IWeatherDAL
    {
        IList<DailyWeatherModel> GetWeatherFromParkCode(string parkCode);
        string TempUnits { get; set; }
    }
}
