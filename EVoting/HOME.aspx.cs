using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EVoting
{
    public partial class HOME : System.Web.UI.Page
    {
        String uname = "admin";
        String pwd = "admin";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == uname && TextBox2.Text == pwd)
            {
                Session["username"] = uname;
                Response.Redirect("ADMINDASH.aspx");
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes; database = eVoting; server = VDILEWVPNTH505");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select count(1) from voter where name = @username and pwd = @password", sqlcon);
                cmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = TextBox1.Text;
                    Response.Redirect("VOTERDASH.aspx");
                }
                else
                {
                    Label3.Visible = true;
                }
            }
        }
    }
}