using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace AutomatedTest
{
    public partial class EmployInsert : System.Web.UI.Page
    {
        SqlConnection connection;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["empconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmd = new SqlCommand("prcEmpAutoGen", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtEmpno.Text = dr[0].ToString();
            connection.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["empconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmd = new SqlCommand("prcEmpInsert", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno",
                Convert.ToInt32(txtEmpno.Text));
            cmd.Parameters.AddWithValue("@name", txtNAme.Text);
            cmd.Parameters.AddWithValue("@dept", txtDept.Text);
            cmd.Parameters.AddWithValue("@desig", txtDesig.Text);
            cmd.Parameters.AddWithValue("@basic",
                Convert.ToInt32(txtBAsic.Text));
            cmd.ExecuteNonQuery();
            lblResult.Text = "Record Inserted...";
        }
    }
}