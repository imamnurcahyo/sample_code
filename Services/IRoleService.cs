using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<MstBoRoleAccess>> GetAllRolesAsync();
        Task<MstBoRoleAccess> GetRoleByIdAsync(int roleId);
        Task<MstBoRoleAccess> CreateRoleAsync(MstBoRoleAccess role);
        Task<MstBoRoleAccess> UpdateRoleAsync(int roleId, MstBoRoleAccess role);
        Task<bool> DeleteRoleAsync(int roleId);
    }
}
