using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public class RoleService : IRoleService
    {
        private readonly ApplicationDbContext _context;

        public RoleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MstBoRoleAccess>> GetAllRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<MstBoRoleAccess> GetRoleByIdAsync(int roleId)
        {
            return await _context.Roles.FindAsync(roleId);
        }

        public async Task<MstBoRoleAccess> CreateRoleAsync(MstBoRoleAccess role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }

        public async Task<MstBoRoleAccess> UpdateRoleAsync(int roleId, MstBoRoleAccess role)
        {
            var existingRole = await _context.Roles.FindAsync(roleId);
            if (existingRole == null)
            {
                return null;
            }

            existingRole.RoleName = role.RoleName;
            existingRole.RoleDescription = role.RoleDescription;
            existingRole.IsActive = role.IsActive;
            existingRole.ModifiedDate = role.ModifiedDate;
            existingRole.ModifiedBy = role.ModifiedBy;

            await _context.SaveChangesAsync();
            return existingRole;
        }

        public async Task<bool> DeleteRoleAsync(int roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            if (role == null)
            {
                return false;
            }

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
