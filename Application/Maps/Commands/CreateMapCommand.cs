﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Maps.Commands
{
    public class CreateMapCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackgroundTitle { get; set; }
    }
}
