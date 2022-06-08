using System.Threading.Tasks;
using Zadanie8.DTOs;
using Zadanie8.Helpers;

namespace Zadanie8.Repositories.Interfaces
{
    public interface IAccountsDbRepository
    {
        public Task<DbAnswer> RegisterAsync(UserDto dto);
        public Task<LoginHelper> LoginAsync(UserDto dto);
        public Task<LoginHelper> UpdateAccessTokenAsync(RefreshTokenDto dto);
    }
}