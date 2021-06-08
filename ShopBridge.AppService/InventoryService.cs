using ShopBridge.DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBridge.DbRepository.Interfaces;

namespace ShopBridge.AppService
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository InventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            this.InventoryRepository = inventoryRepository;
        }

        public async Task<int> DeleteItemDetails(int id)
        {
            return await this.InventoryRepository.DeleteItemDetails(id);
        }

        public async Task<List<ItemDetail>> GetAllItemDetails()
        {
            return await InventoryRepository.GetAllItemDetails();
        }

        public async Task<ItemDetail> GetItemDetails(int id)
        {
            return await this.InventoryRepository.GetItemDetails(id);
        }

        public async Task<int> InsertItemDetails(ItemDetail itemDetail)
        {
            return await this.InventoryRepository.InsertItemDetails(itemDetail);
        }

        public async Task<int> UpdateItemDetails(ItemDetail itemDetail)
        {
            return await this.InventoryRepository.UpdateItemDetails(itemDetail);
        }
    }
}
