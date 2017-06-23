using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SilcoSedonaCustomApi.Models;
using SilcoSedonaCustomApi;


namespace SilcoSedonaCustomApi.Controllers
{
    public class SV_TicketUserDefController : ApiController
    {
      
                [HttpPost]
                public HttpResponseMessage Post([FromBody] SVTicketUserDef f)
                {
                      var srchinsp =
                              Helper.CustSilco_UpdateSVTicketUserdef(f.ticketnumber, f.inreviewflag);

         
                      return  Request.CreateResponse(HttpStatusCode.OK);
                 }

        

        
    }
}
