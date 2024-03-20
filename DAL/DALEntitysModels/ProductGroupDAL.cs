using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALEntitysModels
{
    public class ProductGroupDAL
    {
        public string Name { get; set; }
        public ProductGroupDAL? Parent { get; set; }
        public List<ProductGroupDAL>? Children { get; set; }
    }
}
