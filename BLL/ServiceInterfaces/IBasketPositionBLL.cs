using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IBasketPositionBLL
    {
        public void update(BasketPositionRequestDTO basketPositionRequestDTO);
        public void add(BasketPositionRequestDTO basketPositionRequestDTO);
        public void delete(int id);

    }
}
