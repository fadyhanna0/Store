using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class OrderItem
    {
        [ForeignKey("Order")]
        public int Order_Id { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public int quantity { get; set; }
        [Column(TypeName = "money")]

        public decimal Total_item_price { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }



    }
}
