using System;

namespace PluralSightBookWebsite.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }


        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Register.aspx");
        }

    }
}
