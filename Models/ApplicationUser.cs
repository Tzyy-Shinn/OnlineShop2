using Microsoft.AspNetCore.Identity;

namespace OnlineShop2.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string addressC { get; set; }
        public bool budgetlimit { get; set; }
        public string budgetLimAmount { get; set; }
        
    }
}
