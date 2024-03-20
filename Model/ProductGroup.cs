using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public ProductGroup? Parent { get; set; }
        public List<ProductGroup>? Children { get; set; }
        public List<Product> Products { get; set; }
    }
}
