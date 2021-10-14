using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        { Response.Write("Page_PreInit" + "<br/>"); }

        protected void Page_Init(object sender, EventArgs e)
        { Response.Write("Page_Init" + "<br/>"); }

        protected void Page_InitComplete(object sender, EventArgs e)
        { Response.Write("Page_InitComplete" + "<br/>"); }

        protected void Page_PreLoad(object sender, EventArgs e)
        { Response.Write("Page_PreLoad" + "<br/>"); }

        protected void Page_Load(object sender, EventArgs e)
        { Response.Write("Page_Load" + "<br/>"); }

        protected void Page_LoadComplete(object sender, EventArgs e)
        { Response.Write("Page_LoadComplete" + "<br/>"); }

        protected void Page_PreRender(object sender, EventArgs e)
        { Response.Write("Page_PreRender" + "<br/>"); }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        { Response.Write("Page_PreRenderComplete" + "<br/>"); }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page_Unload" + "<br/>"); 
        }

        //  Postback event, immediately sent to server for processing
        //  
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Clicked <br />");
        }

        //  Cached event, cached/saved in the the page's view state (when clicking outside text
        //  is still there). until a postback occurs they are cached in the view state, the cached events
        //  and the postback events are executed together
        //  
        //  AutoPostBack to automatically post to the server when the text is
        //  is modified. tab or lose focus
        //
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed <br />");
        }

        //  Validation events occur on the client, the check occurs before postback


    }
}