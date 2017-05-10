using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilcoSedonaCustomApi.Models
{
    public class CustSilco_SV_Inspection
    {
       public int inspectionid { get; set; }
        public DateTime nextdate { get; set; }
        public int routeid { get; set; }
    }
}