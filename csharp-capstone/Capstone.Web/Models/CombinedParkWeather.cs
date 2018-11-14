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
        private string tempUnits;

        public CombinedParkWeather(ParkDataModel park, IList<DailyWeatherModel> weather, string tempUnits)
        {
            this.park = park;
            this.weather = weather;
            this.tempUnits = tempUnits;
        }

        public int ConvertTemp(int temp)
        {
            if (temp != 0 && temp - 32 != 0)
            {
                if (this.tempUnits == "C")
                {
                    try
                    {
                        double temporaryTemp = ((double)temp - 32) / (5.0 / 9.0);
                        temp = (int)temporaryTemp;
                    }
                    catch
                    {
                        temp = 0;
                    }
                }
            }
            return temp;
        }

        public Dictionary<string, Object> GetParkWeather()
        {
            Dictionary<string, object> lst = new Dictionary<string, object>();
            lst.Add("park", park);
            lst.Add("weather", weather);
            lst.Add("tempUnits", tempUnits);

            return lst;
        }
    }
}
