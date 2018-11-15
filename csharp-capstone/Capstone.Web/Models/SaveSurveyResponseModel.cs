using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class SaveSurveyResponseModel
    {
        public int SurveyId { get; set; }
        public string ParkCode { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string ActivityLevel { get; set; }

        public SaveSurveyResponseModel(IEnumerable<SelectListItem> parksSelectList)
        {
            this.ParksSelectList = parksSelectList;
        }
        public IEnumerable<SelectListItem> ActivityLevels = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Inactive",  Value="Inactive"},
            new SelectListItem() {Text="Sedentary", Value="Sedentary"},
            new SelectListItem() {Text="Active",    Value="Active"},
            new SelectListItem() {Text="Extremely Active",  Value="ExtremelyActive"}
        };

        public IEnumerable<SelectListItem> States = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Alabama",  Value = "Alabama"},
            new SelectListItem() { Text = "Alaska",   Value = "Alaska"},
            new SelectListItem() { Text = "Arizona",  Value = "Arizona"},
            new SelectListItem() { Text = "Arkansas", Value = "Arkansas"},
            new SelectListItem() { Text = "California",       Value = "California"},
            new SelectListItem() { Text = "Colorado", Value = "Colorado"},
            new SelectListItem() { Text = "Connecticut",      Value = "Connecticut"},
            new SelectListItem() { Text = "Delaware", Value = "Delaware"},
            new SelectListItem() { Text = "Florida",  Value = "Florida"},
            new SelectListItem() { Text = "Georgia",  Value = "Georgia"},
            new SelectListItem() { Text = "Hawaii",   Value = "Hawaii"},
            new SelectListItem() { Text = "Idaho",    Value = "Idaho"},
            new SelectListItem() { Text = "Illinois", Value = "Illinois"},
            new SelectListItem() { Text = "Indiana",  Value = "Indiana"},
            new SelectListItem() { Text = "Iowa",     Value = "Iowa"},
            new SelectListItem() { Text = "Kansas",   Value = "Kansas"},
            new SelectListItem() { Text = "Kentucky", Value = "Kentucky"},
            new SelectListItem() { Text = "Louisiana",        Value = "Louisiana"},
            new SelectListItem() { Text = "Maine",    Value = "Maine"},
            new SelectListItem() { Text = "Maryland", Value = "Maryland"},
            new SelectListItem() { Text = "Massachusetts",    Value = "Massachusetts"},
            new SelectListItem() { Text = "Michigan", Value = "Michigan"},
            new SelectListItem() { Text = "Minnesota",        Value = "Minnesota"},
            new SelectListItem() { Text = "Mississippi",      Value = "Mississippi"},
            new SelectListItem() { Text = "Missouri", Value = "Missouri"},
            new SelectListItem() { Text = "Montana",  Value = "Montana"},
            new SelectListItem() { Text = "Nebraska", Value = "Nebraska"},
            new SelectListItem() { Text = "Nevada",   Value = "Nevada"},
            new SelectListItem() { Text = "New Hampshire",     Value = "NewHampshire"},
            new SelectListItem() { Text = "New Jersey",        Value = "NewJersey"},
            new SelectListItem() { Text = "New Mexico",        Value = "NewMexico"},
            new SelectListItem() { Text = "New York",  Value = "NewYork"},
            new SelectListItem() { Text = "North Carolina",    Value = "NorthCarolina"},
            new SelectListItem() { Text = "North Dakota",      Value = "NorthDakota"},
            new SelectListItem() { Text = "Ohio",     Value = "Ohio"},
            new SelectListItem() { Text = "Oklahoma", Value = "Oklahoma"},
            new SelectListItem() { Text = "Oregon",   Value = "Oregon"},
            new SelectListItem() { Text = "Pennsylvania",     Value = "Pennsylvania"},
            new SelectListItem() { Text = "Rhode Island",      Value = "RhodeIsland"},
            new SelectListItem() { Text = "South Carolina",    Value = "SouthCarolina"},
            new SelectListItem() { Text = "South Dakota",      Value = "SouthDakota"},
            new SelectListItem() { Text = "Tennessee",        Value = "Tennessee"},
            new SelectListItem() { Text = "Texas",    Value = "Texas"},
            new SelectListItem() { Text = "Utah",     Value = "Utah"},
            new SelectListItem() { Text = "Vermont",  Value = "Vermont"},
            new SelectListItem() { Text = "Virginia", Value = "Virginia"},
            new SelectListItem() { Text = "Washington",       Value = "Washington"},
            new SelectListItem() { Text = "Washington, D.C.",       Value = "WashingtonDC"},
            new SelectListItem() { Text = "West Virginia",     Value = "WestVirginia"},
            new SelectListItem() { Text = "Wisconsin",        Value = "Wisconsin"},
            new SelectListItem() { Text = "Wyoming",        Value = "Wyoming"}
        };

        public IEnumerable<SelectListItem> ParksSelectList { get; set; }
    }
}
