using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Locations.Commands.Create
{
    public class CreateLocationCommand : IRequest<bool>
    {
        public string Background { get; set; }
        public string Text { get; set; }
        public int MapId { get; set; }
        public int TaskQuestionsId { get; set; }
    }
}
