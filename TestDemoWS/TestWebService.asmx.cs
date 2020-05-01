using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TestDemoWS
{
    /// <summary>
    /// Summary description for TestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestWebService : System.Web.Services.WebService
    {
        public string constr = ConfigurationManager.ConnectionStrings["dbTestWebService"].ConnectionString;

        [WebMethod]
        public DataSet GetQue()
        {
            String q = @"select tQuestion.queId, tQuestion.que, tQuestion.rans,tAns.ans
                    from tAns
                    join tQuestion on tAns.queId = tQuestion.queId
                    where tAns.queId IN (
                    SELECT top 1 queId
                    FROM tQuestion TQ
                    ORDER BY NEWID()); ";

            //string q = @"SELECT top 1 *
            //    FROM tQuestion TQ
            //       ORDER BY NEWID()";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter(q, con))
                {
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    con.Close();
                    return ds;


                }
            }
        }

    }
}
