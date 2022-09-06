using DistEquipment.Shared;
using Microsoft.AspNetCore.Mvc;
using DistEquipment.Server.Data;

namespace DistEquipment.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IDataProduct dataProduct;

        public ProductController(IDataProduct _dataProduct)
        {
            dataProduct = _dataProduct;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await dataProduct.GetAllProducts());
        }

        [HttpGet("{category/{Url}}")]
        public async Task<ActionResult<List<Product>>> GetProductsByUrl(string Url)
        {
            return Ok(await dataProduct.GetProductsByUrl(Url));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProductById(int Id)
        {
            return Ok(await dataProduct.GetProductbyId(Id));
        }
    }
}
