using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class UserGroupRequestDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public List<UserRequestDTO>? Users { get; init; }
    }
}
