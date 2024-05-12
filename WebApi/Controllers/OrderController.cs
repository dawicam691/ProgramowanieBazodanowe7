using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOredrBLL oredrBLL;
        public OrderController(IOredrBLL oredrBLL)
        {
            this.oredrBLL = oredrBLL;
        }
        /*
        public IActionResult Index()
        {
            return View();
        }*/


        [HttpPost]
        public void AddProductToBucket(BasketPositionRequestDTO basketPositionRequestDTO)
        {
            oredrBLL.AddProductToBucket(basketPositionRequestDTO);
        }
        [HttpPut("/{id}/{Amount}")]
        public void changeAmount(int id, int Amount)
        {
            oredrBLL.changeAmount(id, Amount);
        }
        [HttpDelete("{id}")]
        public void deleteBasketPosition(int id)
        {
            oredrBLL.delete(id);
        }
        [HttpGet("{id}")]
        public List<BasketPositionResponseDTO> getByUserId(int id)
        {
            return oredrBLL.getBasketPositions(id);
        }
    }
}
