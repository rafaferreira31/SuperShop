using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace MVCSuperShop.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
