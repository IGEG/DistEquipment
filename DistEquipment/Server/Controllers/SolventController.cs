using DistEquipment.Shared;
using Microsoft.AspNetCore.Mvc;
using DistEquipment.Server.Data;

namespace DistEquipment.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SolventController : ControllerBase
    {
        private readonly IDataSolvent dataSolvent;

        public SolventController(IDataSolvent _dataSolvent)
        {
            dataSolvent = _dataSolvent;
        }


        [HttpGet]
        public async Task<ActionResult<List<Solvent>>> GetAllSolvents()
        {
            return Ok(await dataSolvent.GetAllSolvents());
        }
    }
}