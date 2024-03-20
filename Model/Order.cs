using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }
        public DateTime Date { get; set; }
        public List<OrderPosition>? Positions { get; set; }
        public bool isPaid { get; set; }
    }
}
