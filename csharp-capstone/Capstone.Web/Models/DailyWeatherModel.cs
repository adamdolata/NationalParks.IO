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
        public string Message
        {
            get
            {
                return DetermineMessage();
            }
        }
        public string TempUnits { get; set; }

        public DailyWeatherModel()
        {
            this.HighTemp = ConvertTemp(this.HighTemp);
            this.LowTemp = ConvertTemp(this.LowTemp);
        }

        private int ConvertTemp(int temp)
        {
            if(TempUnits == "C")
            {
                temp = (temp - 32) / (5 / 9);
            }
            return temp;
        }

        private string DetermineMessage()
        {
            string message = "";
            switch(Forecast)
            {
                case "snow":
                    message = "Pack snowshoes! ";
                    break;
                case "rain":
                    message = "Pack rain gear and wear waterproof shoes! ";
                    break;
                case "thunderstorms":
                    message = "Seek shelter and avoid hiking on exposed ridges! ";
                    break;
                case "sun":
                    message = "Wear sunblock! ";
                    break;
            }
            if (HighTemp >= 75)
            {
                message += "Bring a gallon of water.";
            }
            if ((HighTemp-LowTemp) > 20)
            {
                message += "Wear breathable layers.";
            }
            if (LowTemp <= 20)
            {
                message += "EXPOSURE WARNING! Dangerously freezing temperatures.";
            }

            return message;
        }
    }
}
