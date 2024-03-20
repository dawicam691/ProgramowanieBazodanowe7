using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class BasketPositionResponseDTO
    {
        public int Id { get; init; }
        public ProductResponseDTO? Product { get; init; }
        public UserResponseDTO? User { get; init; }
        public int Amount { get; init; }
    }
}
