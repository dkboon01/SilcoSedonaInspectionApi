using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SilcoSedonaCustomApi.Models;
using SilcoSedonaCustomApi;
using SilcoSedonaInspectionApi;

namespace SilcoSedonaCustomApi.Controllers
{
    public class InvoiceController : ApiController
    {
        private SilcoSedona db = new SilcoSedona();

       // public HttpResponseMessage Get(int siteid, int customerid)
       public HttpResponseMessage Get(int siteid, int customerid)
        {
            //  parm.siteid
            //    parm.servcomp
            
            // List<CustSilco_AllInspForSiteServiceComp_Result> srchinsp = 
    var  invoices =
               Helper.CustSilco_Invoices<CustSilco_SelectInvoicesForPastDues_Result>(siteid, customerid).ToList();


            return Request.CreateResponse(HttpStatusCode.OK, invoices);
        }

        

    }
}
