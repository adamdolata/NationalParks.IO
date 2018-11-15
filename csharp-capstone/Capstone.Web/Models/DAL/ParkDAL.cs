using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Capstone.Web.Models.DAL
{
    public class ParkDAL : IParkDAL
    {
        private readonly string connectionString;

        public ParkDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        


        public ParkDataModel GetParkFromCode(string parkCode)
        {
            ParkDataModel park = new ParkDataModel();
            string query = "SELECT TOP 1 * FROM PARK WHERE parkcode = @parkCode";

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
                        park = RowToPark(reader);
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Unable to get all parks");
                throw;
            }

            return park;
        }


        public IList<ParkDataModel> GetAllParks()
        {
            IList<ParkDataModel> parks = new List<ParkDataModel>();
            string query = "SELECT * FROM PARK";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        parks.Add(RowToPark(reader));
                    }
                }

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Unable to get all parks");
                throw;
            }

            return parks;

        }

        private ParkDataModel RowToPark(SqlDataReader reader)
        {
            return new ParkDataModel
            {
                ParkCode = Convert.ToString(reader["parkCode"]),
                ParkName = Convert.ToString(reader["parkName"]),
                State = Convert.ToString(reader["state"]),
                Acreage = Convert.ToInt32(reader["acreage"]),
                Elevation = Convert.ToInt32(reader["elevationInFeet"]),
                TrailLength = Convert.ToInt32(reader["milesOfTrail"]),
                CampsiteNumber = Convert.ToInt32(reader["numberOfCampsites"]),
                Climate = Convert.ToString(reader["climate"]),
                YearFounded = Convert.ToInt32(reader["yearFounded"]),
                AnnualVisitors = Convert.ToInt32(reader["annualVisitorCount"]),
                Quote = Convert.ToString(reader["inspirationalQuote"]),
                QuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]),
                Description = Convert.ToString(reader["parkDescription"]),
                EntryFee = Convert.ToDecimal(reader["entryFee"]),
                NumSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"])
            };
        }


    }
}
