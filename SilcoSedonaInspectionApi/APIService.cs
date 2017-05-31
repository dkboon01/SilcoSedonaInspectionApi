using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Http.Filters;
using SilcoSedonaInspectionApi.Models;
using System.Security.Principal;
using System.Threading;
using System.Web.Http.Controllers;
using System.Net.Http;

namespace SilcoSedonaInspectionApi
{
    public class APIService
    {
        public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
        {
            public override void OnAuthorization(HttpActionContext actionContext)
            {
                if (actionContext.Request.Headers.Authorization == null)
                {
                    actionContext.Response = actionContext.Request
                    .CreateResponse(HttpStatusCode.Unauthorized);
                }
                else
                {
                    string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                    string decodedAuthenticationToken = Encoding.UTF8.GetString(
                    Convert.FromBase64String(authenticationToken));
                    string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
                    string username = usernamePasswordArray[0];
                    string password = usernamePasswordArray[1];
                   //This is poor practice I know but I'm trying to hurry up and currently there is only one application using API;
                    int applicationid = Convert.ToInt16((System.Configuration.ConfigurationManager.AppSettings.GetValues("Application")[0])) ;

                    if (APISecurity.Login(username, password, applicationid))
                    {
                        Thread.CurrentPrincipal = new GenericPrincipal(
                        new GenericIdentity(username), null);
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request
                        .CreateResponse(HttpStatusCode.Unauthorized);
                    }
                }
            }
        }
    }
}