using Domain.Entities.Admin.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILocationRepository
    {
        Task<LocationTemplate> GetById(int locationId);
        Task AddLocation(LocationTemplate location);
    }
}
