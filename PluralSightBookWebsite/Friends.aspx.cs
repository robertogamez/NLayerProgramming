using Microsoft.AspNet.Identity.Owin;
using PluralSightBookWebsite.Code;
using PluralSightBookWebsite.Models;
using System;
using System.Linq;
using System.Web;

namespace PluralSightBookWebsite
{
    public partial class Friends : System.Web.UI.Page
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return SignInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        protected async void Page_Load(object sender, EventArgs e)
        {
            var user = new ApplicationUser
            {
                UserName = "test3@gmail.com",
                Email = "test3@gmail.com",
            };

            var result = await UserManager.CreateAsync(user, "Macarrom_1");

            if (result.Succeeded)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                Response.Redirect("~/");
            }
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Friend> GridView1_GetData()
        {

            ApplicationDbContext db = new ApplicationDbContext();

            return db.Friends;
        }
    }
}