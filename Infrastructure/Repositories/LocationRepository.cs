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
    public class LocationRepository : ILocationRepository
    {
        private readonly TWDbContext _context;

        public LocationRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddLocation(LocationTemplate location)
        {
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
        }

        public async Task<LocationTemplate> GetById(int locationId)
        {
            return await _context.Locations.FirstOrDefaultAsync(location => location.Id == locationId);
        }

       

        public async Task<IEnumerable<LocationTemplate>> GetLocationsByMapIdAsync(int mapId)
        {
            return await _context.Locations
                .Where(lt => lt.MapTemplateId == mapId)
                .ToListAsync();
        }
    }
}
