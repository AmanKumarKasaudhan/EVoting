using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EVoting
{
    public partial class ADMINDASH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) // manage voters
        {
            Response.Redirect("VOTER.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CANDIDATE.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ELECTION.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("VOTES.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOME.aspx");
        }
    }
}