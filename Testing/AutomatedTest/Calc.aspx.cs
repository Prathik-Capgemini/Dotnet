using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomatedTest
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFno.Text);
            b = Convert.ToInt32(txtSno.Text);
            c = a + b;
            txtRes.Text = c.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFno.Text);
            b = Convert.ToInt32(txtSno.Text);
            c = a - b;
            txtRes.Text = c.ToString();
        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFno.Text);
            b = Convert.ToInt32(txtSno.Text);
            c = a * b;
            txtRes.Text = c.ToString();
        }
    }
}