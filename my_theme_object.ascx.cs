using System;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Security;


namespace starter_theme_object
{

    public partial class my_theme_object : PortalModuleBase
    {

        protected void Page_load(object sender, System.EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            lblMessage.Text = "This starter Theme Object actually works!";
        }

    }

}
