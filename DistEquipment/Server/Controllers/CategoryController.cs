using DistEquipment.Server.Data;
using DistEquipment.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DistEquipment.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IDataCategory _dataCategory;

        public CategoryController(IDataCategory dataCategory)
        {
            _dataCategory = dataCategory;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllCategories()
        {
            return Ok(await _dataCategory.GetAllCategories());
        }
    }
}
