using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RemarkableRaccoons_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIan_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #1255";
        }

        protected void btnColton_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #";
        }

        protected void btnSai_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #";
        }

        protected void btnLucas_Click(object sender, EventArgs e)
        {
            lblLeetCode.Text = "Leet Code Problem #";
        }
    }
}