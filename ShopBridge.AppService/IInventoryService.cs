using ShopBridge.DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.AppService
{
    public interface IInventoryService
    {
        Task<List<ItemDetail>> GetAllItemDetails();

        Task<DataModel.ServiceModel.ItemDetail> GetItemDetails(int id);

        Task<int> DeleteItemDetails(int id);

        Task<int> InsertItemDetails(DataModel.ServiceModel.ItemDetail itemDetail);

        Task<int> UpdateItemDetails(ItemDetail itemDetail);
    }
}
