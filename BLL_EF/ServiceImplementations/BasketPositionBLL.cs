using BLL.DTOModels.Request;
using BLL.ServiceInterfaces;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF.ServiceImplementations
{
    public class BasketPositionBLL : IBasketPositionBLL
    {
        private DAL.WebshopContext context = new WebshopContext();

        public void add(BasketPositionRequestDTO basketPositionRequestDTO)
        {
            BasketPosition basketPosition = new BasketPosition();
            basketPosition.Id = context.BasketPositions.Max(x => x.Id)+1;
            basketPosition.ProductId = basketPositionRequestDTO.productId;
            basketPosition.UserId = basketPositionRequestDTO.userId;
            basketPosition.Amount = basketPositionRequestDTO.amount;
            context.BasketPositions.Add(basketPosition);
            context.SaveChanges();
        }

        public void delete(int id)
        {
            context.BasketPositions.Remove(context.BasketPositions.Where(x=>x.Id == id).First());
            context.SaveChanges();
        }

        public void update(BasketPositionRequestDTO basketPositionRequestDTO)
        {
            BasketPosition basketPosition = context.BasketPositions.Where(x => x.Id == basketPositionRequestDTO.Id).First();
            basketPosition.ProductId = basketPositionRequestDTO.productId;
            basketPosition.UserId = basketPositionRequestDTO.userId;
            basketPosition.Amount=basketPositionRequestDTO.amount;
        }
    }
}
