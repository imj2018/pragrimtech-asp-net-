using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ApplicationEventsDemo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //  ["TotalApplications"] how session type variables are named like var TotalApplications 
            // 
            // Create Application state variable
            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            // Increment TotalApplications by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;
        }
    }
}