using ShopBridge.DataModel.ServiceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.API.Model
{
    public class UpdateItemModel : BaseItemModel
    {
        [Required]
        public int Id { get; set; }

        internal ItemDetail ToItemDetails()
        {
            return new ItemDetail
            {
                Id = this.Id,
                Description = this.Description,
                Name = this.Name,
                Price = this.Price,
                Quantity = this.Quantity
            };
        }
    }
}
