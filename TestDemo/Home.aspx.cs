using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestDemo.testDemoServiceReference;

namespace TestDemo
{
    public partial class Home : System.Web.UI.Page
    {
        static int quecnt = 1;
        static int correct = 1;
       // static int incorrect = 0;
        static string ra;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string uname = Request.QueryString["username"];
                HiddenField1.Value = uname;
                lblQueNo.Text = quecnt.ToString();
                lblcorrect.Text = correct.ToString();
              //  lblincorrect.Text = incorrect.ToString();
                Test();
            }
        }
        private void Clear()
        {
            if (rbtnA.Checked)
            {
                rbtnA.Checked = false;
            }
            if (rbtnB.Checked)
            {
                rbtnB.Checked = false;
            }
            if (rbtnC.Checked)
            {
                rbtnC.Checked = false;
            }
            if (rbtnD.Checked)
            {
                rbtnD.Checked = false;
            }
        }



        public void Test()
        {

            DataSet ds = new DataSet();
            //DataRow dr = new DataRow();
            TestWebServiceSoapClient ques = new TestWebServiceSoapClient();
            ds = ques.GetQue();
            //dr = ds.Tables[0].Rows[];
            String[] ans = new String[4];
            var quesId = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            //qa.queId = Convert.ToInt32(quesId);
            txtQue.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
            // qa.que = txtQue.Text;
            var rans = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            // qa.rAns = rans;
            ra = rans;
            var ans1 = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();

            for (int i = 0; i < 4; i++)
            {
                ans[i] = ds.Tables[0].Rows[i].ItemArray.GetValue(3).ToString();

            }
            rbtnA.Text = ans[0];
            rbtnB.Text = ans[1];
            rbtnC.Text = ans[2];
            rbtnD.Text = ans[3];


        }

        protected void btnNextQue_Click(object sender, EventArgs e)
        {
            if (quecnt < 3)
            {
                quecnt++;
                lblQueNo.Text = quecnt.ToString();               
                if(rbtnA.Checked ==true && rbtnA.Text == ra )
                {                    
                        correct++;
                        lblcorrect.Text = correct.ToString();
                    
                }
                if (rbtnB.Checked == true && rbtnB.Text == ra)
                {
                    correct++;
                    lblcorrect.Text = correct.ToString();

                }
                if (rbtnC.Checked == true && rbtnC.Text == ra)
                {
                    correct++;
                    lblcorrect.Text = correct.ToString();

                }
                if (rbtnD.Checked == true && rbtnD.Text == ra)
                {
                    correct++;
                    lblcorrect.Text = correct.ToString();

                }            
                Clear();
                Test();
            }
            else
            {
                Response.Redirect("result.aspx?result=" +correct+ "&uname="+ HiddenField1.Value+" ");
              //  Response.Redirect("default2.aspx ?firstname=" + TextBox1.Text + "&lastname=" + TextBox2.Text);
            }
        }


    }
}