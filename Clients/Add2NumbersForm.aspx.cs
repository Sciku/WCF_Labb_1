using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clients
{
    public partial class Add2NumbersForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Add2NumbersReference.TwoNumberAddSoapClient client = new Add2NumbersReference.TwoNumberAddSoapClient();
            Label1.Text = client.AddTwoNumbers(TextBox1.Text, TextBox2.Text);
        }
    }
}