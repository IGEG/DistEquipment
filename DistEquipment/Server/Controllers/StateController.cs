using DistEquipment.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DistEquipment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IDataState _dataState;

        public StateController(IDataState dataState)
        {
            _dataState = dataState;
        }
        [HttpPost]
        public async Task AddVisit()
        {
            await _dataState.AddVisit();
        }
        [HttpGet]
        public async ValueTask<ActionResult<int>> GetVisits()
        {
           return await _dataState.GetVisits();
        }
    }
}
