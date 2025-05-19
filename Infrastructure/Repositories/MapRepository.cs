using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MapRepository : IMapRepository
    {
        public readonly TWDbContext _context;

        public MapRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddMap(Map map)
        {
            await _context.Maps.AddAsync(map);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Map>> GetAllMaps()
        {
            return await _context.Maps.ToListAsync();
        }

        public async Task<Map> GetMapById(int mapId)
        {
            return await _context.Maps.FirstOrDefaultAsync(map => map.Id == mapId);
        }
    }
}
