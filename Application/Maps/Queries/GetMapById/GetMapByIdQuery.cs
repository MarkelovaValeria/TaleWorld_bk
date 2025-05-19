using Domain.Entities.Admin.Map;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Maps.Queries.GetMapById
{
    public class GetMapByIdQuery : IRequest<Map>
    {
        public int id { get; set; }

        public GetMapByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
