using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class UserRequestDTO
    {
        public int Id { get; init; }
        public string Login { get; init; }
        public string Password { get; init; }
        public UserTypeDTO Type { get; init; }
        public bool IsActive { get; init; }
        public UserGroupRequestDTO? Group { get; init; }
        public List<OrderRequestDTO> Orders { get; init; }
        public List<BasketPositionRequestDTO> BasketPositions { get; init; }
    }
}
