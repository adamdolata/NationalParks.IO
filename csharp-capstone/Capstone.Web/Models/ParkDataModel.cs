using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class ParkDataModel
    {
        public string ParkCode { get; set; }
        public string ParkName { get; set; }
        public string State { get; set; }
        public double Acreage { get; set; }
        public double Elevation { get; set; }
        public double TrailLength { get; set; }
        public int CampsiteNumber { get; set; }
        public string Climate { get; set; }
        public int YearFounded { get; set; }
        public int AnnualVisitors { get; set; }
        public string Quote { get; set; }
        public string QuoteSource { get; set; }
        public string Description { get; set; }
        public decimal EntryFee { get; set; }
        public int NumSpecies { get; set; }
    }
}
