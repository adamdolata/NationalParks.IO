using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models.DAL
{
    public class WeatherDAL : IWeatherDAL
    {
        private readonly string connectionString;

        public WeatherDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<DailyWeatherModel> GetWeatherFromParkCode(string parkCode)
        {
            IList<DailyWeatherModel> weather = new List<DailyWeatherModel>();
            string query = "SELECT * FROM weather WHERE parkCode = @parkCode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@parkCode", parkCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        weather.Add(RowToWeather(reader));
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Unable to get all parks");
                throw;
            }

            return weather;
        }

        private DailyWeatherModel RowToWeather(SqlDataReader reader)
        {
            return new DailyWeatherModel
            {
                Day = Convert.ToInt32(reader["fiveDayForecastValue"]),
                ParkCode = Convert.ToString(reader["parkCode"]),
                Forecast = Convert.ToString(reader["forecast"]),
                HighTemp = Convert.ToInt32(reader["high"]),
                LowTemp = Convert.ToInt32(reader["low"])
            };
        }
    }
}
