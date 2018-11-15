using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class SurveyResultModel
    {
        public int SurveyId { get; set; }
        public string ParkCode { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string ActivityLevel { get; set; }
        public enum StateName
        {
            Alabama,
            Alaska,
            Arizona,
            Arkansas,
            California,
            Colorado,
            Connecticut,
            Delaware,
            Florida,
            Georgia,
            Hawaii,
            Idaho,
            Illinois,
            Indiana,
            Iowa,
            Kansas,
            Kentucky,
            Louisiana,
            Maine,
            Maryland,
            Massachusetts,
            Michigan,
            Minnesota,
            Mississippi,
            Missouri,
            Montana,
            Nebraska,
            Nevada,
            [Display(Name = "New Hampshire")]
            NewHampshire,
            [Display(Name = "New Jersey")]
            NewJersey,
            [Display(Name = "New Mexico")]
            NewMexico,
            [Display(Name = "New York")]
            NewYork,
            [Display(Name = "North Carolina")]
            NorthCarolina,
            [Display(Name = "North Dakota")]
            NorthDakota,
            Ohio,
            Oklahoma,
            Oregon,
            Pennsylvania,
            [Display(Name = "Rhode Island")]
            RhodeIsland,
            [Display(Name = "South Carolina")]
            SouthCarolina,
            [Display(Name = "South Dakota")]
            SouthDakota,
            Tennessee,
            Texas,
            Utah,
            Vermont,
            Virginia,
            Washington,
            [Display(Name = "West Virginia")]
            WestVirginia,
            Wisconsin,
            Wyoming
        }
    }
}
