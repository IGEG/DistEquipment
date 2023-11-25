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

        public CategoryController(IDataCategory dataCategory, ILogger<CategoryController> logger)
        {
            logger.LogInformation("created CategoryController");
            _dataCategory = dataCategory;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllCategories()
        {
            return Ok(await _dataCategory.GetAllCategories());
        }

        [HttpGet("{Url}")]
        public async Task<ActionResult<List<Product>>> GetCategoryByUrl(string Url)
        {
            return Ok(await _dataCategory.GetCategoryByUrl(Url));
        }
    }
}
