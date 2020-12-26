using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCountries = new DataTable();
        DataTable dtCountries1 = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int Sum(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("CountryName");
            dtCountries.Columns.Add("Continent");

            dtCountries.Rows.Add("Pakistan", "Asia");
            dtCountries.Rows.Add("VietNam", "Asia");
            dtCountries.Rows.Add("Germany", "Europe");
            dtCountries.Rows.Add("Endland", "Europe");

            return JsonConvert.SerializeObject(dtCountries);
        }

        [WebMethod]
        public DataTable get_Countries()
        {
            dtCountries1.Columns.Add("CountryName");
            dtCountries1.Columns.Add("Continent");

            dtCountries1.Rows.Add("Pakistan", "Asia");
            dtCountries1.Rows.Add("VietNam", "Asia");
            dtCountries1.Rows.Add("Germany", "Europe");
            dtCountries1.Rows.Add("Endland", "Europe");

            return dtCountries1;
        }
    }
}
