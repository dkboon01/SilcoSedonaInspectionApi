using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilcoSedonaInspectionApi.Models
{
    public class EditLog
    {
       public string user { get; set; }
        public string inspectiontype { get; set; }
        public string systemcode { get; set; }
        public string sitecode  { get; set; }
        public string action { get; set; }
        public string code { get; set; }
        public int  customernumber { get; set; }
    }
}