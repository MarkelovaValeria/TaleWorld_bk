using Domain.Entities.Admin.Map;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Maps.Queries.GetAllMaps
{
    public class GetAllMapsQuery : IRequest<List<Map>>
    {
        public GetAllMapsQuery() { }
    }
}
