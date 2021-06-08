using System.ComponentModel.DataAnnotations;

namespace ShopBridge.API
{
    public class DeleteItemModel
    {
        [Required]
        public int Id { get; set; }
    }
}