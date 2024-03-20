using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class ProductGroupResponseDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public ProductGroupResponseDTO? Parent { get; init; }
        public List<ProductGroupResponseDTO>? Children { get; init; }
        public List<ProductResponseDTO>? Products { get; init; }
    }
}
