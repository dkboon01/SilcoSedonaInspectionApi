using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

using System.Net;
using System.IO;
using System.Configuration;
using System.Data;
using System.Collections;
using SilcoSedonaCustomApi;

using System.Data.Entity;

using System.Data.SqlClient;
using SilcoSedonaCustomApi.Models;
using System.Globalization;
using SilcoSedonaInspectionApi;

namespace SilcoSedonaCustomApi.Models
{

    public class Helper
    {
        public static List<CustSilco_AllInspForSiteServiceComp_Result> CustSilco_AllInspForSiteServiceComp   <T>(int siteid, int servcomp)

        where T : class
        {
            var db = new Silco_FinalEntities1();
            List<CustSilco_AllInspForSiteServiceComp_Result> inspsearch = db.CustSilco_AllInspForSiteServiceComp(siteid, servcomp).ToList();
            return inspsearch;
          
        }
    }
}