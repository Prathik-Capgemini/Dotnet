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
    public partial class EmpDelete : System.Web.UI.Page
    {
        SqlConnection connection;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["empconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmd = new SqlCommand("prcEmpDelete", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Empno", Convert.ToInt32(txtEmpno.Text));
            cmd.Parameters.Add(new SqlParameter("@result", SqlDbType.VarChar, 30));
            cmd.Parameters["@result"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            lblResult.Text = "Records Deleted";

        }
    }
}