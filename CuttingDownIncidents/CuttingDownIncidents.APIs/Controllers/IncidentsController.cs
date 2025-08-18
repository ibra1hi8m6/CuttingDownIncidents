using CuttingDownIncidents.Infrastructure.ViewModel;
using CuttingDownIncidents.Service.Implementation.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
namespace CuttingDownIncidents.APIs.Controllers
{
    [ApiController]
    [Route("api/Incidents")]
    [EnableRateLimiting("BandwidthLimit")]
    public class IncidentsController : ControllerBase
    {
        /* [HttpPost("create")]
         [EnableRateLimiting("BandwidthLimit")]*/

        private readonly IGetDataService _getDataService;

        public IncidentsController(IGetDataService getDataService)
        {
            _getDataService = getDataService;
        }

        [HttpGet("GetProblemTypes")]
        public async Task<ActionResult<IEnumerable<ProblemTypesDTO>>> GetAllMeals()
        {
            var result = await _getDataService.GetAllproblemTypesAsync();
            return Ok(result);
        }

    }
}
