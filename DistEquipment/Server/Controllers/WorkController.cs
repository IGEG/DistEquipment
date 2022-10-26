using DistEquipment.Server.Data;
using DistEquipment.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistEquipment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly IDataWork _dataWork;

        public WorkController(IDataWork dataWork)
        {
            _dataWork = dataWork;
        }
        [HttpGet]
        public async Task<ActionResult<List<Work>>> GetAllWork()
        {
            return Ok(await _dataWork.GetAllWork());
        }
    }
}
