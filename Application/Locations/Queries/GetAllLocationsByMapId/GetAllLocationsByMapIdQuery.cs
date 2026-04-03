using Domain.Entities;
using Domain.Entities.Admin.Map;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Locations.Queries.GetAllLocationsByMapId
{
    public class GetAllLocationsByMapIdQuery : IRequest<IEnumerable<LocationTemplate>>
    {
        public int MapId { get; }

        public GetAllLocationsByMapIdQuery(int mapId)
        {
            MapId = mapId;
        }
    }
}
