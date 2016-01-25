using System;
using System.Web.Security;

namespace OpenRedirection
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                FormsAuthentication.SetAuthCookie(UsernameTextBox.Text, false);
                Response.Redirect(Request.QueryString["ReturnUrl"]);
            }
        }

        //protected void LoginButton_Click(object sender, EventArgs e)
        //{
        //    if (FormsAuthentication.Authenticate(UsernameTextBox.Text, PasswordTextBox.Text))
        //    {
        //        FormsAuthentication.SetAuthCookie(UsernameTextBox.Text, false);

        //        string returnUrl = Request.QueryString["ReturnUrl"];

        //        if (!IsLocalUrl(returnUrl))
        //        {
        //            Response.Redirect(FormsAuthentication.DefaultUrl);
        //        }
        //        else
        //        {
        //            Response.Redirect(Request.QueryString["ReturnUrl"]);
        //        }
        //    }
        //}

        //private bool IsLocalUrl(string url)
        //{
        //    return IsUrlLocalToHost(url);
        //}

        //private bool IsUrlLocalToHost(string url)
        //{
        //    return !string.IsNullOrWhiteSpace(url) &&
        //           ((url[0] == '/' && (url.Length == 1 ||
        //            (url[1] != '/' && url[1] != '\\'))) ||   // "/" or "/foo" but not "//" or "/\"
        //            (url.Length > 1 &&
        //             url[0] == '~' && url[1] == '/'));   // "~/" or "~/foo"
        //}
    }
}