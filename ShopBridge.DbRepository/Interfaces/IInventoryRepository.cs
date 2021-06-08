using ShopBridge.DataModel.ServiceModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ShopBridge.DbRepository.Interfaces
{
    public interface IInventoryRepository
    {
        Task<List<ItemDetail>> GetAllItemDetails();
        
        Task<ItemDetail> GetItemDetails(int id);
        
        Task<int> DeleteItemDetails(int id);
        
        Task<int> InsertItemDetails(ItemDetail itemDetail);
        Task<int> UpdateItemDetails(ItemDetail itemDetail);
    }
}
