using Microsoft.AspNetCore.Identity;
using MVCSuperShop.Data.Entities;

namespace MVCSuperShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}
