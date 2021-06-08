using ShopBridge.AppService;
using ShopBridge.DataModel.ServiceModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ShopBridge.API.Model;

namespace ShopBridge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        public IInventoryService InventoryService { get; set; }

        public InventoryController(ShopBridge.AppService.IInventoryService fireServce)
        {
            this.InventoryService = fireServce;
        }


        [HttpGet("getall")]
        public async Task<List<ShopBridge.DataModel.ServiceModel.ItemDetail>> Get()
        {
           var result = await InventoryService.GetAllItemDetails();
            return result;
        }

        [HttpGet]
        public async Task<ShopBridge.DataModel.ServiceModel.ItemDetail> Get([FromQuery] GetItemDetailsModel getItemDetailsModel)
        {
            var result = await InventoryService.GetItemDetails(getItemDetailsModel.Id);
            return result;
        }

        [HttpDelete]
        public async Task<int> Delete([FromQuery] DeleteItemModel deleteItemModel)
        {
            var result = await InventoryService.DeleteItemDetails(deleteItemModel.Id);
            return result;
        }

        [HttpPost]
        public async Task<int> InsertItemDetails(AddItemModel addItemModel)
        {
            var itemId = await InventoryService.InsertItemDetails(addItemModel.ToItemDetails());
            return itemId;
        }

        [HttpPut]
        public async Task<int> UpdateItemDetails(UpdateItemModel updateItemModel)
        {
            var itemId = await InventoryService.UpdateItemDetails(updateItemModel.ToItemDetails());
            return itemId;
        }
    }
}
