using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.API.Model
{
    public class GetItemDetailsModel
    {
        [Required]
        public int Id { get; set; }
    }
}
