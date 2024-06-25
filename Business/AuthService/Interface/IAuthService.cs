using SecuredHub.Models;

namespace SecuredHub.Business.AuthService.Interface
{
    public interface IAuthService
    {
        public Task<User> Login(string email, string password);
        public Task<User> Register(User user);
        public Task<bool> UsernameExists(string username);
        public Task Logout();
    }
}
