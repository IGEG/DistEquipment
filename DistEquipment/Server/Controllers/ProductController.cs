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
    }
}
