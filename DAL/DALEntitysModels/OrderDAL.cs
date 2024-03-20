using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALEntitysModels
{
    public class OrderDAL
    {
        public UserDAL? User { get; set; }
        public DateTime Date { get; set; }
        public List<OrderPositionDAL>? Positions { get; set; }
    }
}
