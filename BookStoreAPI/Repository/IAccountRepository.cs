using BookStoreAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace BookStoreAPI.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SingUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(LoginModel loginModel);
    }
}
