using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMSWebApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (YourValidationFunction(Login1.UserName, Login1.Password))
            {
                // e.Authenticated = true;  
                Login1.Visible = false;
                Label1.Text = "Successfully Logged In";
            }
            else
            {
                e.Authenticated = false;
            }
        }
        private bool YourValidationFunction(string UserName, string Password)
        {
            bool boolReturnValue = false;
            string strConnection = "server=DESKTOP-PC9TJRI;database=sqlpractice;uid=sa;pwd=P@ssw0rd;";
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            String SQLQuery = "SELECT UserName, Password FROM Users";
            SqlCommand command = new SqlCommand(SQLQuery, sqlConnection);
            SqlDataReader Dr;
            sqlConnection.Open();
            Dr = command.ExecuteReader();
            while (Dr.Read())
            {
                if ((UserName == Dr["UserName"].ToString()) & (Password == Dr["Password"].ToString()))
                {
                    boolReturnValue = true;
                }
                Dr.Close();
                return boolReturnValue;
            }
            return boolReturnValue;
        }
    }
}
