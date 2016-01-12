using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeatherForm.AddTwoNumbersReference;

namespace WeatherForm
{
    public partial class AddFrom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AddTwoNumbersReference.TwoNumberAddSoapClient client = new AddTwoNumbersReference.TwoNumberAddSoapClient();
            Label1.Text = client.AddTwoNumbers(TextBox1.Text, TextBox2.Text);
        }
    }
}