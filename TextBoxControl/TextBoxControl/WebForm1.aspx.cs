using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextBoxControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox3.Text = "";
            }

            TextBox6.Focus();

            //  last will receive the focus
            TextBox7.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello" + TextBox3.Text);
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed");
        }

    }
}