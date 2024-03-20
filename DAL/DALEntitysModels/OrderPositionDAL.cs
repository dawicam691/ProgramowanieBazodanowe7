using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALEntitysModels
{
    public class OrderPositionDAL
    {
        public OrderDAL? Order { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}
