using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Http.ExceptionHandling;
using SilcoSedonaCustomApi.Models;

namespace SilcoSedonaCustomApi
{
    public class CustomAPIExceptionHandling : ExceptionLogger
    {
       


        public override void Log(ExceptionLoggerContext context)
        {
            var log = context.Exception.ToString();
            Helper.CustSilco_insertlog(log, "CustomAPI");

            
            
        }

    }
}