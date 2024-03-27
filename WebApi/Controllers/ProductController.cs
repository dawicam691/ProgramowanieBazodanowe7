using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using BLL_DB;
using BLL_EF.ServiceImplementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductsBLL productsBLL;
        public ProductController(IProductsBLL productsBLL)
        {
            this.productsBLL = productsBLL;
        }
        [HttpGet]
        public IEnumerable<ProductResponseDTO> get()
        {
            return productsBLL.get();
        }
        [Route("test")]
        [HttpGet]
        public ProductResponseDTO getOne()
        {
            ProductBLL_DB productBLL_DB = new ProductBLL_DB();
            productBLL_DB.get();

            return new ProductResponseDTO();
        }
    }
}
