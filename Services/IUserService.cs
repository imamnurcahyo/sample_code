using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IUserService
    {
        Task<IEnumerable<MstBoUser>> GetAllUsersAsync();
        Task<MstBoUser> GetUserByIdAsync(int userId);
        Task<MstBoUser> CreateUserAsync(MstBoUser user);
        Task<MstBoUser> UpdateUserAsync(int userId, MstBoUser user);
        Task<bool> DeleteUserAsync(int userId);
    }
}
