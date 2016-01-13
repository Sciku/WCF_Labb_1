using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF_Labb_1
{
    /// <summary>
    /// Summary description for NameDay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NameDay : System.Web.Services.WebService
    {

        [WebMethod]
        public string InputNameReturnDate(string inputname)
        {
            var textFromFile = System.IO.File.ReadAllLines(@"D:\VS projects\WCF_Labb_1\Clients\Namnsdagar.txt");
            var dateOfNameDay = "";

            foreach (var line in textFromFile)
            {
                var split = line.Split(' ', ',');

                if (split.Contains(inputname))
                {
                    dateOfNameDay = "Månad: " + split[1] + " " + "Dag: " + split[0];

                }
            }
            return dateOfNameDay;
        }
    }
}
