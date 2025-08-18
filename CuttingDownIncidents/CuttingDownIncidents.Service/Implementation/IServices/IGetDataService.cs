using CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy;
using CuttingDownIncidents.Infrastructure.ViewModel;

namespace CuttingDownIncidents.Service.Implementation.IServices
{
    public interface IGetDataService
    {


        // ProblemType methods
        Task<IEnumerable<ProblemTypesDTO>> GetAllproblemTypesAsync();

        // Hierarchy methods
        Task<IEnumerable<Governrate>> GetAllGovernratesAsync();
        Task<IEnumerable<Sector>> GetSectorsByGovernrateKeyAsync(int governrateKey);
        Task<IEnumerable<Zone>> GetZonesBySectorKeyAsync(int sectorKey);
        Task<IEnumerable<City>> GetCitiesByZoneKeyAsync(int zoneKey);
        Task<IEnumerable<Station>> GetStationsByCityKeyAsync(int cityKey);
        Task<IEnumerable<Tower>> GetTowersByStationKeyAsync(int stationKey);
        Task<IEnumerable<Cabin>> GetCabinsByTowerKeyAsync(int towerKey);
        Task<IEnumerable<Cable>> GetCablesByCabinKeyAsync(int cabinKey);
    }
}