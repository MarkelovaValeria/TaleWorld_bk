using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Maps.Queries.GetAllMaps
{
    public class GetAllMapsQueryHandler : IRequestHandler<GetAllMapsQuery, List<Map>>
    {
        private readonly IMapRepository _mapRepository;

        public GetAllMapsQueryHandler(IMapRepository mapRepository)
        {
            _mapRepository = mapRepository;
        }

        public async Task<List<Map>> Handle(GetAllMapsQuery request, CancellationToken cancellationToken)
        {
            
            return await _mapRepository.GetAllMaps();
        }
    }
}
