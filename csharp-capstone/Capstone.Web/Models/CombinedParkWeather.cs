using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class CombinedParkWeather
    {
        private ParkDataModel park;
        private IList<DailyWeatherModel> weather;

        public CombinedParkWeather(ParkDataModel park, IList<DailyWeatherModel> weather)
        {
            this.park = park;
            this.weather = weather;
        }

        public Dictionary<string, Object> GetParkWeather()
        {
            Dictionary<string, object> lst = new Dictionary<string, object>();
            lst.Add("park", park);
            lst.Add("weather", weather);

            return lst;
        }
    }
}
