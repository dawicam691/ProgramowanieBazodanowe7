using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class ProductGroupRequestDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public ProductGroupRequestDTO? Parent { get; init; }
        public List<ProductGroupRequestDTO>? Children { get; init; }
        public List<ProductRequestDTO>? Products { get; init; }
    }
}
