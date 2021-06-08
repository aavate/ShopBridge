using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ShopBridge.DataModel.ServiceModel;
using ShopBridge.DbRepository.Interfaces;

namespace ShopBridge.DbRepository
{
    public class InventoryRepository : BaseRepository, Interfaces.IInventoryRepository
    {
        public async Task<List<ItemDetail>> GetAllItemDetails()
        {
            using (var conn = GetConnection())
            {
                var query = @"SELECT ID, Name, Description, Quantity, Price FROM Inventory;";

                var queryResult = await conn.QueryAsync<ItemDetail>(query);
                return queryResult.ToList();
            }
        }

        public async Task<ItemDetail> GetItemDetails(int id)
        {
            using (var conn = GetConnection())
            {
                var query = @"SELECT ID, Name, Description, Quantity, Price FROM Inventory where ID= @id;";

                var queryResult = await conn.QueryAsync<ItemDetail>(query, new { id = id });
                return queryResult.FirstOrDefault();
            }
        }

        public async Task<int> InsertItemDetails(ItemDetail itemDetail)
        {
            using (var conn = GetConnection())
            {
                var query = @"INSERT INTO Inventory (Name, Description, Quantity, Price) VALUES(@name, @description, @quantity, @price)";

                var itemId = await conn.QueryAsync<int>(query, new { name = itemDetail.Name, description = itemDetail.Description, quantity = itemDetail.Quantity, price = itemDetail.Price });
                return itemId.FirstOrDefault();
            }


        }

        public async Task<int> DeleteItemDetails(int id)
        {
            using (var conn = GetConnection())
            {
                var query = @"Delete FROM Inventory where ID= @id;";

                var queryResult = await conn.QueryAsync<int>(query, new { id = id });
                return queryResult.FirstOrDefault();
            }
        }

        public async Task<int> UpdateItemDetails(ItemDetail itemDetail)
        {
            using (var conn = GetConnection())
            {
                var query = @"UPDATE Inventory SET Name=@name, Description=@description, Quantity=@quantity, Price=@price WHERE ID=@id;";

                var itemId = await conn.QueryAsync<int>(query, new { id = itemDetail.Id, name = itemDetail.Name, description = itemDetail.Description, price = itemDetail.Price, quantity = itemDetail.Quantity });
                return itemId.FirstOrDefault();
            }
        }
    }
}
