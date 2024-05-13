using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IOredrBLL
    {
        public OrderResponseDTO get(OrderRequestDTO orderRequestDTO);
        public void pay(OrderRequestDTO orderRequestDTO);
        public List<OrderResponseDTO> getOrders(
            ProductSortingEntityDTO sortingEntityBLL = ProductSortingEntityDTO.NULL, 
            SortingTypeDTO sortingType = SortingTypeDTO.ASC, 
            OrderSortingEntityDTO orderSortingEntityDTO = OrderSortingEntityDTO.NULL, 
            string sotringContent = null, 
            OrderFilteringDTO orderFilteringDTO = OrderFilteringDTO.PAID_AND_UNPAID,
            string filteringContent = null);
        public void AddProductToBucket(BasketPositionRequestDTO basketPositionRequestDTO);
        public void changeAmount(int id, int Amount);
        public void delete(int id);
        public List<BasketPositionResponseDTO> getBasketPositions(int userId);

    }
}
