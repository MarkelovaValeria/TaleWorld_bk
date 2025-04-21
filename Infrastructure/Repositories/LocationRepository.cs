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
    public class LocationRepository : ILocationRepository
    {
        private readonly TWDbContext _context;

        public LocationRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddLocation(Location location)
        {
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
        }
    }
}
