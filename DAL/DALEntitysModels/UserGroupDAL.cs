using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALEntitysModels
{
    public class UserGroupDAL
    {
        public string Name { get; set; }
        public List<UserGroupDAL>? Users { get; set; }
    }
}
