using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EVoting
{
    public partial class CANDIDATE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("HOME.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)   // ADD
        {
            String query = "insert into CANDIDATE values (@ID,@Name,@AGE,@EID);";
            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes; database = eVoting; server = VDILEWVPNTH513");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@AGE", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@EID", TextBox4.Text.Trim());
            

            cmd.ExecuteNonQuery();
            sqlcon.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            
        }

        protected void Button2_Click(object sender, EventArgs e)   // UPDATE
        {
            String query = "update CANDIDATE set age = @age where id = " + TextBox1.Text + "";
            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes; database = eVoting; server = VDILEWVPNTH513");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);

            cmd.Parameters.AddWithValue("@age", TextBox3.Text.Trim());

           

            cmd.ExecuteNonQuery();
            sqlcon.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
      
        }

        protected void Button3_Click(object sender, EventArgs e)  // SELECT
        {
            int i = 0;
            String query = "select * from CANDIDATE where ID = " + TextBox1.Text + "";
            SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = eVoting;server = VDILEWVPNTH513");
            sqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((i >= 0) && (i < ds.Tables[0].Rows.Count))
            {
                TextBox2.Text = ds.Tables[0].Rows[i][1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[i][2].ToString();
                TextBox4.Text = ds.Tables[0].Rows[i][3].ToString();
               
            }
        }

        protected void Button4_Click(object sender, EventArgs e) // DELETE
        {
            String query = "delete from CANDIDATE where id = " + TextBox1.Text + "";
            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes;database = eVoting;server = VDILEWVPNTH513");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}