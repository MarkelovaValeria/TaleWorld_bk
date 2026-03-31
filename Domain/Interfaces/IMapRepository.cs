using Domain.Entities;
using Domain.Entities.Admin.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMapRepository
    {
        Task AddMap(MapTemplate map);
        Task<List<MapTemplate>> GetAllMaps();
        Task<MapTemplate> GetMapById(int mapId);
    }
}
