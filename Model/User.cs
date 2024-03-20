using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public bool IsActive {  get; set; }
        public int? GroupId { get; set; }
        [ForeignKey(nameof(GroupId))]
        public UserGroup? Group { get; set; }
        public List<Order> Orders { get; set; }
        public List<BasketPosition> BasketPositions { get; set; }
    }
}
