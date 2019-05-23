using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EMSWebApp
{
    public partial class LoginPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string strcon = ConfigurationManager.ConnectionStrings["employconn"].ConnectionString;
        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd;
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("PrcUserAuthenticate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", txtUsrname.Text);
                cmd.Parameters.AddWithValue("@passWord", txtPassword.Text);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Response.Redirect("DisplayEmploys.aspx");
                }
                else
                {
                    //conn.Close();

                }
            }
            catch (Exception ex)
            {

                Label1.Text=ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}