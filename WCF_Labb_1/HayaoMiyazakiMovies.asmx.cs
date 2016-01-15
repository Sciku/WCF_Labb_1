using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF_Labb_1
{
    /// <summary>
    /// Summary description for HayaoMiyazakiMovies
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HayaoMiyazakiMovies : System.Web.Services.WebService
    {

        [WebMethod]
        public string WriteYearReturnMovie(string inputYear)
        {
            var textFromFile = System.IO.File.ReadAllLines(@"D:\VS projects\WCF_Labb_1\Clients\HayaoMiyazakiMovies.txt");
            var movieTitle = "";

            foreach (var line in textFromFile)
            {
                var split = line.Split('\t', ',');

                if (split.Contains(inputYear))
                {
                    movieTitle = "Filmen/filmerna som släpptes det året var: " + split[1] + "," + split[2];

                }
            }
            return movieTitle;
        }
    }
}
