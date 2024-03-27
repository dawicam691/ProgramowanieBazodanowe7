using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using DAL;
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
    }
}
