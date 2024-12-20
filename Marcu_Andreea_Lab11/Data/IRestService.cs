using System.Threading.Tasks;
using Marcu_Andreea_Lab11.Models;

namespace Marcu_Andreea_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
