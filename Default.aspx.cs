using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitTestWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SSO.AspNet.VerificationClient verfi = new SSO.AspNet.VerificationClient("http://localhost:4177/signout.aspx");


            if (verfi.IsLogin == false)
            {
                verfi.Login();
                return;
            }
        }
    }
}