﻿using System;
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
    public partial class EmpUpdate : System.Web.UI.Page
    {
        SqlConnection connection;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["empconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmd = new SqlCommand("prcEmpUpdate", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Empno",
                Convert.ToInt32(txtEmpno.Text));
            cmd.Parameters.AddWithValue("@Nam",
                txtNAme.Text);
            cmd.Parameters.AddWithValue("@Dept",
                txtDept.Text);
            cmd.Parameters.AddWithValue("@Desig",
                txtDesig.Text);
            cmd.Parameters.AddWithValue("@Basic",
               Convert.ToInt32(txtBAsic.Text));
            cmd.ExecuteNonQuery();
            lblResult.Text = "Record Updated...";
        }

        protected void txtEmpno_TextChanged(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["empconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmd = new SqlCommand("prcEmpOut", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno",
                Convert.ToInt32(txtEmpno.Text));
            cmd.Parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar, 30));
            cmd.Parameters["@Nam"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@Dept", SqlDbType.VarChar, 30));
            cmd.Parameters["@Dept"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@Desig", SqlDbType.VarChar, 30));
            cmd.Parameters["@Desig"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@Basic", SqlDbType.Int));
            cmd.Parameters["@Basic"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            txtNAme.Text = cmd.Parameters["@Nam"].Value.ToString();
            txtDept.Text = cmd.Parameters["@Dept"].Value.ToString();
            txtDesig.Text = cmd.Parameters["@Desig"].Value.ToString();
            txtBAsic.Text = cmd.Parameters["@Basic"].Value.ToString();
            connection.Close();
        }
    }
}