﻿using System;
using System.Web.Security;

namespace OpenRedirection
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogOutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
        }
    }
}