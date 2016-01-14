using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clients
{
    public partial class MiyazakiForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MiyazakiReference.HayaoMiyazakiMoviesSoapClient client = new MiyazakiReference.HayaoMiyazakiMoviesSoapClient();
            Label1.Text = client.WriteYearReturnMovie(TextBox1.Text);
        }
    }
}