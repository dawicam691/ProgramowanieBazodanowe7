using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class BasketPosition
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }
        public int Amount { get; set; }
    }
}
