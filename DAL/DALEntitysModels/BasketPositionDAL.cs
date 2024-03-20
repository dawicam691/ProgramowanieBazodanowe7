using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALEntitysModels
{
    public class BasketPositionDAL
    {
        public ProductDAL? Product { get; set; }
        public UserDAL? User { get; set; }
        public int Amount { get; set; }
    }
}
