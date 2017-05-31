using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilcoSedonaInspectionApi.Models
{
    public class APISecurity
    {
        public static bool Login(string username, string password, int applicationid)
        {
            try
            {
                using (Cust_SilcoEntities entities = new Cust_SilcoEntities())
                {

                    List<SelectAPISecurity_Result> sec = entities.SelectAPISecurity(applicationid).ToList();

                    foreach (var s in sec)
                    {
                        if (s.ApiUserName == username && s.ApiPassWord == password)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}