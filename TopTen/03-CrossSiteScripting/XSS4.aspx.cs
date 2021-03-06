﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_CrossSiteScripting
{
    public partial class XSS4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            XSSLiteral.Text = RichTextBox.Text;
            EncodedLiteral.Text = Server.HtmlEncode(RichTextBox.Text);
            SafeLiteral.Text = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(RichTextBox.Text);

            RichTextBox.Text = string.Empty;
        }
    }
}