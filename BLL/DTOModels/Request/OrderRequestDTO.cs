using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels.Request
{
    public class OrderRequestDTO
    {
        //public int Id { get; init; }
        //public UserRequestDTO? User { get; init; }
        int userID { get; init; }
        public DateTime Date { get; init; }
        public bool? isPaid { get; init; }
    }
}
