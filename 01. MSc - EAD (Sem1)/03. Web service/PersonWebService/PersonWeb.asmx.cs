using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PersonWebService
{
    /// <summary>
    /// Summary description for PersonWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PersonWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable returnTable()
        {
            DataTable dataTable = new DataTable("PersonWeb");

            dataTable.Columns.Add("PersonName", typeof(String));
            dataTable.Columns.Add("PersonID", typeof(String));
            dataTable.Columns.Add("PersonAge", typeof(String));

            dataTable.Rows.Add("Bob", "001", "25");
            dataTable.Rows.Add("Jack", "002", "23");
            dataTable.Rows.Add("Tom", "003", "21");

            return dataTable;
        }
    }
}
