using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Locations.Commands.Create
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, bool>
    {
        private readonly ILocationRepository _location;

        public CreateLocationCommandHandler(ILocationRepository location)
        {
            _location = location;
        }

        public async Task<bool> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var locations = new Location
            {
                Background = request.Background,
                Text = request.Text,
                MapId = request.MapId,
                TaskQuestionsId = request.TaskQuestionsId,
            };

            await _location.AddLocation(locations);
            return true;
        }
    }
}
