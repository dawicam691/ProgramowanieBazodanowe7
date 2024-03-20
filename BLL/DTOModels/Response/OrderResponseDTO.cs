using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class OrderResponseDTO
    {
        public int UserId { get; init; }
        public UserResponseDTO? User { get; init; }
        public List<BasketPositionResponseDTO>? BasketPositions { get; init; }
        public DateTime Date { get; init; }
        public string value { get; init; }
        //flaga
    }
}
