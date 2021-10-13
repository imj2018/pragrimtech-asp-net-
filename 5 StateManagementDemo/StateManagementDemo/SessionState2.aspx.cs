using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class SessionState2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  if get request not a post
            if (!IsPostBack)
            {
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox1.Text = Session["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int clicksCount = (int)Session["Clicks"] + 1;
            //TextBox1.Text = clicksCount.ToString();
            Session["Clicks"] = clicksCount;
            TextBox1.Text = clicksCount.ToString();

        }
    }
}