using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class DailyWeatherModel
    {
        public string ParkCode { get; set; }
        public int Day { get; set; }
        public int LowTemp { get; set; }
        public int HighTemp { get; set; }
        public string Forecast { get; set; }
    }
}
