using System.Threading.Tasks;

namespace Rova.Core.Interfaces
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(string username, string password);
        Task LogoutAsync();
        Task<bool> RegisterMerchantAsync(string username, string password, string email);
        Task<bool> RegisterWorkerAsync(string username, string password, string email);
        Task<bool> ValidateUserRoleAsync(string username);
    }
}