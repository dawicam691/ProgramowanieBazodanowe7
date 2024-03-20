using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image {  get; set; }
        public bool IsActive { get; set; }
        public int? GroupId { get; set; }
        [ForeignKey(nameof(GroupId))]
        public ProductGroup? Group { get; set; }
        public List<BasketPosition> BasketPositions { get; set; }
    }
}
