using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALEntitysModels
{
    public class ProductDAL
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public ProductGroupDAL? Group { get; set; }
        public List<BasketPositionDAL>? BasketPositionsDAL { get; set; }
    }
}
