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


    }
}
