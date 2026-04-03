using Application.Courses.Queries.GetAllCoursesByUserId;
using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Locations.Queries.GetAllLocationsByMapId
{
    public class GetAllLocationsByMapIdQueryHandler : IRequestHandler<GetAllLocationsByMapIdQuery, IEnumerable<LocationTemplate>>
    {
        private readonly ILocationRepository _locationRepository;

        public GetAllLocationsByMapIdQueryHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IEnumerable<LocationTemplate>> Handle(GetAllLocationsByMapIdQuery request, CancellationToken cancellationToken)
        {
            var locations = await _locationRepository.GetLocationsByMapIdAsync(request.MapId);
            return locations ?? new List<LocationTemplate>();
        }
    }
}
