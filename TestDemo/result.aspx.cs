using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestDemo
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string result = Request.QueryString["result"];
                string uname = Request.QueryString["uname"];
                lblname.Text =uname;
                lblscore.Text =result;
            }

        }


    }
}