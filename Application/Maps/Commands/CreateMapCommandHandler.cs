using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Maps.Commands
{
    internal class CreateMapCommandHandler : IRequestHandler<CreateMapCommand, bool>
    {
        private readonly IMapRepository _map;

        public CreateMapCommandHandler(IMapRepository map)
        {
            _map = map;
        }

        public async Task<bool> Handle(CreateMapCommand request, CancellationToken cancellationToken)
        {
            var maps = new Map
            {
                Name = request.Name,
                BackgroundTitle = request.BackgroundTitle,
                Description = request.Description,
            };
            await _map.AddMap(maps);
            return true;
        }
    }
}
