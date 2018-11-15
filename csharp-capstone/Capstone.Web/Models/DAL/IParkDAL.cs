using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public interface IParkDAL
    {
        IList<ParkDataModel> GetAllParks();
        ParkDataModel GetParkFromCode(string parkCode);
    }
}
