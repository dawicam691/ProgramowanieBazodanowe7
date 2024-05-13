using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using DAL;
using Model;

namespace BLL_EF.ServiceImplementations
{
    public class OredrBLL : BLL.ServiceInterfaces.IOredrBLL
    {
        private DAL.WebshopContext context = new WebshopContext();
        public OrderResponseDTO get(OrderRequestDTO orderRequestDTO)
        {
            throw new NotImplementedException();
        }

        public List<OrderResponseDTO> getOrders(ProductSortingEntityDTO sortingEntityBLL = ProductSortingEntityDTO.NULL, SortingTypeDTO sortingType = SortingTypeDTO.ASC, OrderSortingEntityDTO orderSortingEntityDTO = OrderSortingEntityDTO.NULL, string sotringContent = null, OrderFilteringDTO orderFilteringDTO = OrderFilteringDTO.PAID_AND_UNPAID, string filteringContent = null)
        {
            throw new NotImplementedException();
        }

        public void pay(OrderRequestDTO orderRequestDTO)
        {
            throw new NotImplementedException();
        }
        public void AddProductToBucket(BasketPositionRequestDTO basketPositionRequestDTO)
        {
            BasketPosition basketPosition = new BasketPosition();
            basketPosition.ProductId = basketPositionRequestDTO.productId;
            basketPosition.UserId = basketPositionRequestDTO.userId;
            basketPosition.Amount = basketPositionRequestDTO.amount;
            context.BasketPositions.Add(basketPosition);
            context.SaveChanges();
        }
        public void changeAmount(int id, int Amount)
        {
            BasketPosition basketPosition = context.BasketPositions.Where(x => x.Id == id).FirstOrDefault();
            if(basketPosition != null)
            {
                basketPosition.Amount = Amount;
                context.BasketPositions.Update(basketPosition);
                context.SaveChanges();
            }
        }
        public void delete(int id)
        {
            BasketPosition basketPosition =  context.BasketPositions.Where(x => x.Id == id).FirstOrDefault();
            context.BasketPositions.Remove(basketPosition);
            context.SaveChanges();
        }
        public List<BasketPositionResponseDTO> getBasketPositions(int userId)
        {
            List<BasketPosition> basketPositions =  context.BasketPositions.Where(x=>x.UserId == userId).ToList();
            List<BasketPositionResponseDTO> result = new List<BasketPositionResponseDTO>();
            foreach(var basketPosition in basketPositions)
            {
                Product product = context.Products.Where(x => x.Id == basketPosition.ProductId).FirstOrDefault();
                ProductResponseDTO productResponseDTO = new ProductResponseDTO { Name = product.Name, Price = product.Price };
                User user = context.Users.Where(x => x.Id == basketPosition.UserId).FirstOrDefault();
                UserResponseDTO userResponseDTO = new UserResponseDTO {Login = user .Login, Password = user .Password, IsActive = user .IsActive, };
                BasketPositionResponseDTO basketPositionResponseDTO = new BasketPositionResponseDTO {Product = productResponseDTO, User = userResponseDTO, Amount = basketPosition .Amount};
                result.Add(basketPositionResponseDTO);
            }
            return result;
        }
    }
}
