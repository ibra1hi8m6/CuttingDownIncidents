using CuttingDownIncidents.Infrastructure.ViewModel;
using CuttingDownIncidents.Service.Implementation.IServices;
using CuttingDownIncidents.Service.Implementation.Servies;
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
        private readonly ICuttingDownService _cuttingDownService;
        public IncidentsController(IGetDataService getDataService, ICuttingDownService cuttingDownService)
        {
            _getDataService = getDataService;
            _cuttingDownService = cuttingDownService;
        }

        [HttpGet("GetProblemTypes")]
        public async Task<ActionResult<IEnumerable<ProblemTypesDTO>>> GetAllProblemTypes()
        {
            var result = await _getDataService.GetAllproblemTypesAsync();
            return Ok(result);
        }
        [HttpGet("CuttingDownIgnored")]
        public async Task<IActionResult> GetAllCuttingDownIgnoredAsync()
        {
            var data = await _getDataService.GetAllCuttingDownIgnoredAsync();
            return Ok(data);
        }
        [HttpGet("NetworkElementHierarchyPath")]
        public async Task<IActionResult> GetAllNetworkElementHierarchyPathAsync() 
        {
            var data = await _getDataService.GetAllNetworkElementHierarchyPathAsync();
            return Ok(data);
        }


        [HttpGet("Channels")]
        public async Task<ActionResult<IEnumerable<ChannelDTO>>> GetAllChannels()
        {
            var result = await _getDataService.GetAllChannelsAsync();
            return Ok(result);
        }
        [HttpGet("NetworkElementTypes")]
        public async Task<ActionResult<IEnumerable<NetworkElementTypeDTO>>> GetAllNetworkElementTypes()
        {
            var result = await _getDataService.GetAllNetworkElementTypesAsync();
            return Ok(result);
        }

        [HttpPost("search")]
        public async Task<IActionResult> SearchIncidents([FromBody] CuttingDownSearchFilter filter)
        {
            try
            {
                var result = await _cuttingDownService.SearchIncidentsAsync(filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateIncident([FromBody] CreateCuttingDownIncidentDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid input.");

            try
            {
                var id = await _cuttingDownService.CreateIncidentAsync(dto);
                return Ok(new { Cutting_Down_Key = id });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
