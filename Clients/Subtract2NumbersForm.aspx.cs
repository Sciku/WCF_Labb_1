using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clients
{
    public partial class Subtract2NumbersForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Subtract2NumbersReference.TwoNumberSubSoapClient client = new Subtract2NumbersReference.TwoNumberSubSoapClient();
            Label1.Text = client.SubtractTwoNumbers(TextBox1.Text, TextBox2.Text);
        }
    }
}