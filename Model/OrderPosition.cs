using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class OrderPosition
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
    }
}
