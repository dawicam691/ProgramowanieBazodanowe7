using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Response
{
    public class UserResponseDTO
    {
        public int Id { get; init; }
        public string Login { get; init; }
        public string Password { get; init; }
        public UserTypeDTO Type { get; init; }
        public bool IsActive { get; init; }
        public UserGroupResponseDTO? Group { get; init; }
        public List<OrderResponseDTO> Orders { get; init; }
        public List<BasketPositionResponseDTO> BasketPositions { get; init; }
    }
}
