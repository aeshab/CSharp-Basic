using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        localhost.WebService1 calc = new localhost.WebService1();


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSub_Click(object sender, EventArgs e)
        {
            lblRes.Text = calc.Sub(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();      
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            lblRes.Text = calc.Add(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString(); 
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {

            lblRes.Text = calc.Mul(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString(); 
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {

            lblRes.Text = calc.Div(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString(); 
        }

      
        
    }
}