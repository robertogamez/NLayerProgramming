using PluralSightBookWebsite.Code;
using System;

namespace PluralSightBookWebsite
{
    public partial class AddFriend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();
            var newFriend = context.Friends.Create();
            newFriend.UserId = "0c7a38b1-25d7-4ca1-9213-4572a0db5d59";
            newFriend.Email = EmailTextBox.Text;
            context.Friends.Add(newFriend);
            context.SaveChanges();

            Response.Redirect("~/Friends.aspx", true);
        }
    }
}