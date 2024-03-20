using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class OrderPositionRequestDTO
    {
        public int Id { get; init; }
        public OrderRequestDTO? Order { get; init; }
        public int Amount { get; init; }
        public double Price { get; init; }
    }
}
