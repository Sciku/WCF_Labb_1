using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherForm
{
    public partial class Add3NumbersForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Add3NumbersReference.ThreeNumberAddSoapClient client = new Add3NumbersReference.ThreeNumberAddSoapClient();
            Label1.Text = client.AddThreeNumbers(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        }
    }
}