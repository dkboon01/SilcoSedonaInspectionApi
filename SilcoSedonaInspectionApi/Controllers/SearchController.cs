using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SilcoSedonaCustomApi.Models;
using SilcoSedonaCustomApi;
using static SilcoSedonaInspectionApi.APIService;

namespace SilcoSedonaCustomApi.Controllers
{
    public class SearchController : ApiController
    {
        //private CustSilco_AllInspForSiteServiceComp_Result srchinsp;

        // GET: api/Search
        // @RequestMapping(path= "/api/Search/{siteid}/{sitecomp}", method=WebRequestMethods.Get)
        // [Route("api/Search/{siteid}/{servcomp}")]
        //  public List<CustSilco_AllInspForSiteServiceComp_Result>Get(int siteid, int servcomp)
        
        public HttpResponseMessage Get(int siteid, int servcomp)
        {
          //  parm.siteid
            //    parm.servcomp

           // List<CustSilco_AllInspForSiteServiceComp_Result> srchinsp = 
           var srchinsp = 
              Helper.CustSilco_AllInspForSiteServiceComp<CustSilco_AllInspForSiteServiceComp_Result>(siteid, servcomp).ToList();
     
      
                    return  Request.CreateResponse(HttpStatusCode.OK, srchinsp);
        }

                // GET: api/Search/5
                //public string Get(int id)
                //{
                //    return "value";
                //}

                // POST: api/Search
                public void Post([FromBody]string value)
                {
                }

                // PUT: api/Search/5
                public void Put(int id, [FromBody]string value)
                {
                }

                // DELETE: api/Search/5
                public void Delete(int id)
                {
                }
            }
}
