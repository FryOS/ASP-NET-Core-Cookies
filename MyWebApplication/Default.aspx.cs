using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Result.Text = "Load";
        }

        protected void GetResult_Click(object sender, EventArgs e)
        {
            string  result = Name.Text + ", hello";
            Result.Text = result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}