using CuttingDownIncidents.Service.Implementation.IServices;
using CuttingDownIncidents.Service.Implementation.Servies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CuttingDownIncidents.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HierarchyController : ControllerBase
    {
        private readonly IGetDataService _getDataService;

        public HierarchyController(IGetDataService getDataService)
        {
            _getDataService = getDataService;
        }


        [HttpGet("governrates")]
        public async Task<IActionResult> GetAllGovernrates()
        {
            var list = await _getDataService.GetAllGovernratesAsync();
            return Ok(list);
        }

        [HttpGet("sectors/{governrateKey}")]
        public async Task<IActionResult> GetSectorsByGovernrateKey(int governrateKey)
        {
            var list = await _getDataService.GetSectorsByGovernrateKeyAsync(governrateKey);
            return Ok(list);
        }

        [HttpGet("zones/{sectorKey}")]
        public async Task<IActionResult> GetZonesBySectorKey(int sectorKey)
        {
            var list = await _getDataService.GetZonesBySectorKeyAsync(sectorKey);
            return Ok(list);
        }

        [HttpGet("cities/{zoneKey}")]
        public async Task<IActionResult> GetCitiesByZoneKey(int zoneKey)
        {
            var list = await _getDataService.GetCitiesByZoneKeyAsync(zoneKey);
            return Ok(list);
        }

        [HttpGet("stations/{cityKey}")]
        public async Task<IActionResult> GetStationsByCityKey(int cityKey)
        {
            var list = await _getDataService.GetStationsByCityKeyAsync(cityKey);
            return Ok(list);
        }

        [HttpGet("towers/{stationKey}")]
        public async Task<IActionResult> GetTowersByStationKey(int stationKey)
        {
            var list = await _getDataService.GetTowersByStationKeyAsync(stationKey);
            return Ok(list);
        }

        [HttpGet("cabins/{towerKey}")]
        public async Task<IActionResult> GetCabinsByTowerKey(int towerKey)
        {
            var list = await _getDataService.GetCabinsByTowerKeyAsync(towerKey);
            return Ok(list);
        }

        [HttpGet("cables/{cabinKey}")]
        public async Task<IActionResult> GetCablesByCabinKey(int cabinKey)
        {
            var list = await _getDataService.GetCablesByCabinKeyAsync(cabinKey);
            return Ok(list);
        }
    }
}
