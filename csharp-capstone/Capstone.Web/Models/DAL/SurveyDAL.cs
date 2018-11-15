using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public IList<SurveyResultModel> GetAllResponses()
        {
            IList<SurveyResultModel> surveyResponses = new List<SurveyResultModel>();

            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM survey_result", conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        surveyResponses.Add(RowToResponse(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return surveyResponses;
        }

        private SurveyResultModel RowToResponse(SqlDataReader reader)
        {
            return new SurveyResultModel
            {
                SurveyId = Convert.ToInt32(reader["surveyId"]),
                ParkCode = Convert.ToString(reader["parkCode"]),
                Email = Convert.ToString(reader["emailAddress"]),
                State = Convert.ToString(reader["state"]),
                ActivityLevel = Convert.ToString(reader["activityLevel"]),
            };
        }

        public void SaveResponse(SurveyResultModel surveyResponse)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO survey_result VALUES (@parkCode, @emailAddress, @state, @activityLevel);", conn);
                    cmd.Parameters.AddWithValue("@parkCode", surveyResponse.ParkCode);
                    cmd.Parameters.AddWithValue("@emailAddress", surveyResponse.Email);
                    cmd.Parameters.AddWithValue("@state", surveyResponse.State);
                    cmd.Parameters.AddWithValue("@activityLevel", surveyResponse.ActivityLevel);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}
