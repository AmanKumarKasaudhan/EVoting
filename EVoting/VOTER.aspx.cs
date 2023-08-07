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
    public partial class VOTER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("HOME.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e) // insert
        {
            String query = "insert into voter values (@id,@name,@pass,@father,@age,@idissue,@email,@phone,@address,@city,@state,@pincode);";
            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes; database = eVoting; server = VDILEWVPNTH505");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@id", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@name", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", TextBox12.Text.Trim());
            cmd.Parameters.AddWithValue("@father", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@age", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@idissue", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@email", TextBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", TextBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@address", TextBox8.Text.Trim());
            cmd.Parameters.AddWithValue("@city", TextBox9.Text.Trim());
            cmd.Parameters.AddWithValue("@state", TextBox10.Text.Trim());
            cmd.Parameters.AddWithValue("@pincode", TextBox11.Text.Trim());

            cmd.ExecuteNonQuery();
            sqlcon.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e) // update
        {
            String query = "update voter set pwd=@pass,age=@age,email=@email,phone=@phone,address=@address,city=@city,state=@state,pincode=@pincode where id = '" + TextBox1.Text + "'";
            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes; database = eVoting; server = VDILEWVPNTH505");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            
            cmd.Parameters.AddWithValue("@pass", TextBox12.Text.Trim());
            
            cmd.Parameters.AddWithValue("@age", TextBox4.Text.Trim());
            
            cmd.Parameters.AddWithValue("@email", TextBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", TextBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@address", TextBox8.Text.Trim());
            cmd.Parameters.AddWithValue("@city", TextBox9.Text.Trim());
            cmd.Parameters.AddWithValue("@state", TextBox10.Text.Trim());
            cmd.Parameters.AddWithValue("@pincode", TextBox11.Text.Trim());

            cmd.ExecuteNonQuery();
            sqlcon.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e) // select 
        {
            int i = 0;
            String query = "select * from voter where id = '" + TextBox1.Text + "'";
            SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = eVoting;server = VDILEWVPNTH505");
            sqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if ((i >= 0) && (i < ds.Tables[0].Rows.Count))
            {
                TextBox2.Text = ds.Tables[0].Rows[i][1].ToString();
                TextBox3.Text = ds.Tables[0].Rows[i][3].ToString();
                TextBox4.Text = ds.Tables[0].Rows[i][4].ToString();
                TextBox5.Text = ds.Tables[0].Rows[i][5].ToString();
                TextBox6.Text = ds.Tables[0].Rows[i][6].ToString();
                TextBox7.Text = ds.Tables[0].Rows[i][7].ToString();
                TextBox8.Text = ds.Tables[0].Rows[i][8].ToString();
                TextBox9.Text = ds.Tables[0].Rows[i][9].ToString();
                TextBox10.Text = ds.Tables[0].Rows[i][10].ToString();
                TextBox11.Text = ds.Tables[0].Rows[i][11].ToString();
                TextBox12.Text = ds.Tables[0].Rows[i][2].ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String query = "delete from voter where id = '" + TextBox1.Text + "'";
            SqlConnection sqlcon = new SqlConnection("Trusted_Connection = Yes;database = eVoting;server = VDILEWVPNTH505");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
        }
    }
}