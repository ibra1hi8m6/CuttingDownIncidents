using AutoMapper;
using CuttingDownIncidents.Data;
using CuttingDownIncidents.Domain.Entities;
using CuttingDownIncidents.Domain.Entities.FactTables;
using CuttingDownIncidents.Domain.Entities.FactTables.Cutting_Down_Fact;
using CuttingDownIncidents.Domain.Entities.FactTables.Network;
using CuttingDownIncidents.Domain.Entities.Staging_Tables.hierarchy;
using CuttingDownIncidents.Infrastructure.ViewModel;
using CuttingDownIncidents.Service.Implementation.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CuttingDownIncidents.Service.Implementation.Servies
{
    public class GetDataService : IGetDataService
    {
        private readonly IRepository<ProblemType> _problemTypeRepository;
        private readonly IMapper _mapper;
        private readonly IRepository<Governrate> _governrateRepository;
        private readonly IRepository<Sector> _sectorRepository;
        private readonly IRepository<Zone> _zoneRepository;
        private readonly IRepository<City> _cityRepository;
        private readonly IRepository<Station> _stationRepository;
        private readonly IRepository<Tower> _towerRepository;
        private readonly IRepository<Cabin> _cabinRepository;
        private readonly IRepository<Cable> _cableRepository;
        private readonly IRepository<CuttingDownIgnored> _cuttingDownIgnored;
        private readonly IRepository<NetworkElementHierarchyPath> _networkElementHierarchyPath;
        private readonly IRepository<Channel> _channelRepository;
        private readonly IRepository<NetworkElementType> _networkElementTypeRepository;

        public GetDataService(
            
            IRepository<ProblemType> problemTypeRepository,
            IMapper mapper,
             IRepository<Governrate> governrateRepository,
        IRepository<Sector> sectorRepository,
        IRepository<Zone> zoneRepository,
        IRepository<City> cityRepository,
        IRepository<Station> stationRepository,
        IRepository<Tower> towerRepository,
        IRepository<Cabin> cabinRepository,
        IRepository<Cable> cableRepository,
        IRepository<CuttingDownIgnored> cuttingDownIgnored,
        IRepository<NetworkElementHierarchyPath> networkElementHierarchyPath,
           IRepository<Channel> channelRepository,
        IRepository<NetworkElementType> networkElementTypeRepository
            )
        {
            _problemTypeRepository = problemTypeRepository;
            _mapper = mapper;
            _governrateRepository = governrateRepository;
            _sectorRepository = sectorRepository;
            _zoneRepository = zoneRepository;
            _cityRepository = cityRepository;
            _stationRepository = stationRepository;
            _towerRepository = towerRepository;
            _cabinRepository = cabinRepository;
            _cableRepository = cableRepository;
            _cuttingDownIgnored = cuttingDownIgnored;
            _networkElementHierarchyPath = networkElementHierarchyPath;
            _channelRepository = channelRepository;
            _networkElementTypeRepository = networkElementTypeRepository;
        }


        public async Task<IEnumerable<ProblemTypesDTO>> GetAllproblemTypesAsync()
        {
            var CategoryMeals = await _problemTypeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProblemTypesDTO>>(CategoryMeals);
        }
        public async Task<IEnumerable<CuttingDownIgnoredDto>> GetAllCuttingDownIgnoredAsync()
        {
            var entities = await _cuttingDownIgnored.GetAllAsync();
            return _mapper.Map<IEnumerable<CuttingDownIgnoredDto>>(entities);
        }
        public async Task<IEnumerable<NetworkElementHierarchyPathDTO>> GetAllNetworkElementHierarchyPathAsync()
        {
            var entities = await _networkElementHierarchyPath.GetAllAsync();
            return _mapper.Map<IEnumerable<NetworkElementHierarchyPathDTO>>(entities);
        }


        public async Task<IEnumerable<ChannelDTO>> GetAllChannelsAsync()
        {
            var entities = await _channelRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ChannelDTO>>(entities);
        }

        public async Task<IEnumerable<NetworkElementTypeDTO>> GetAllNetworkElementTypesAsync()
        {
            var entities = await _networkElementTypeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<NetworkElementTypeDTO>>(entities);
        }













        public async Task<IEnumerable<Governrate>> GetAllGovernratesAsync()
        {
            return await _governrateRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Sector>> GetSectorsByGovernrateKeyAsync(int governrateKey)
        {
            return await _sectorRepository.GetAllAsync(s => s.Governrate_Key == governrateKey);
        }

        public async Task<IEnumerable<Zone>> GetZonesBySectorKeyAsync(int sectorKey)
        {
            return await _zoneRepository.GetAllAsync(z => z.Sector_Key == sectorKey);
        }

        public async Task<IEnumerable<City>> GetCitiesByZoneKeyAsync(int zoneKey)
        {
            return await _cityRepository.GetAllAsync(c => c.Zone_Key == zoneKey);
        }

        public async Task<IEnumerable<Station>> GetStationsByCityKeyAsync(int cityKey)
        {
            return await _stationRepository.GetAllAsync(s => s.City_Key == cityKey);
        }

        public async Task<IEnumerable<Tower>> GetTowersByStationKeyAsync(int stationKey)
        {
            return await _towerRepository.GetAllAsync(t => t.Station_Key == stationKey);
        }

        public async Task<IEnumerable<Cabin>> GetCabinsByTowerKeyAsync(int towerKey)
        {
            return await _cabinRepository.GetAllAsync(c => c.Tower_Key == towerKey);
        }

        public async Task<IEnumerable<Cable>> GetCablesByCabinKeyAsync(int cabinKey)
        {
            return await _cableRepository.GetAllAsync(c => c.Cabin_Key == cabinKey);
        }
    }
}
