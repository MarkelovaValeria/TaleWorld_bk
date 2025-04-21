using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using Infrastructure.Data;
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
    }
}
