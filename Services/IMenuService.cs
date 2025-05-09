using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IMenuService
    {
        Task<IEnumerable<MstBoMenu>> GetAllMenusAsync();
        Task<MstBoMenu> GetMenuByIdAsync(int menuId);
        Task<MstBoMenu> CreateMenuAsync(MstBoMenu menu);
        Task<MstBoMenu> UpdateMenuAsync(int menuId, MstBoMenu menu);
        Task<bool> DeleteMenuAsync(int menuId);
    }
}
