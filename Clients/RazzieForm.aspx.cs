using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clients
{
    public partial class RazzieForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RazzieReference.WorstMoviesSoapClient client = new RazzieReference.WorstMoviesSoapClient();
            Label1.Text = client.InputYearReturnWorstMovie(TextBox1.Text);
        }
    }
}