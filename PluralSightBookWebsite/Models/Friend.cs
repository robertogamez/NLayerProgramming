namespace PluralSightBookWebsite.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}