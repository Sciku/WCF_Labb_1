using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF_Labb_1
{
    /// <summary>
    /// Summary description for ThreeNumberAdd
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ThreeNumberAdd : System.Web.Services.WebService
    {

        [WebMethod]
        public string AddThreeNumbers(string tal1, string tal2, string tal3)
        {
            var calc = (int.Parse(tal1) + int.Parse(tal2) + int.Parse(tal3)).ToString();
            return calc;
        }
    }
}
