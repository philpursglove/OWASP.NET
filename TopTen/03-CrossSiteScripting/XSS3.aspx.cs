using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_CrossSiteScripting
{
    public partial class XSS3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            XSSLiteral.Text = RichTextBox.Text;

            RichTextBox.Text = string.Empty;
        }
    }
}