using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IRoleMenuAccessService
    {
        Task<IEnumerable<MstBoRoleMenuAccess>> GetAllRoleMenuAccessesAsync();
        Task<MstBoRoleMenuAccess> GetRoleMenuAccessByIdAsync(int roleMenuAccessId);
        Task<MstBoRoleMenuAccess> CreateRoleMenuAccessAsync(MstBoRoleMenuAccess roleMenuAccess);
        Task<MstBoRoleMenuAccess> UpdateRoleMenuAccessAsync(int roleMenuAccessId, MstBoRoleMenuAccess roleMenuAccess);
        Task<bool> DeleteRoleMenuAccessAsync(int roleMenuAccessId);
    }
}
