using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class BasketPositionRequestDTO
    {
        public int Id { get; init; }
        //public int ProductFilteringID {  get; init; }
        //public ProductRequestDTO? Product { get; init; }
        public int productId { get; init; }
        public int userId { get; init; }
        //public UserRequestDTO? User { get; init; }
        public int amount { get; init; }
    }
}
