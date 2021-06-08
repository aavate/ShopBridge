using ShopBridge.DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.API.Model
{
    public class AddItemModel : BaseItemModel
    {

        internal ItemDetail ToItemDetails()
        {
            return new ItemDetail
            {
                Description = this.Description,
                Name = this.Name,
                Price = this.Price,
                Quantity = this.Quantity
            };
        }
    }
}
