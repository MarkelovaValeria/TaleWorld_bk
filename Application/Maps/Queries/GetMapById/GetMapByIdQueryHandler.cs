using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Maps.Queries.GetMapById
{
    public class GetMapByIdQueryHandler : IRequestHandler<GetMapByIdQuery, Map>
    {
        private readonly IMapRepository _mapRepository;

        public GetMapByIdQueryHandler(IMapRepository mapRepository)
        {
            _mapRepository = mapRepository;
        }

        public async Task<Map> Handle(GetMapByIdQuery request, CancellationToken cancellationToken)
        {
            return await _mapRepository.GetMapById(request.id);
        }
    }
}
