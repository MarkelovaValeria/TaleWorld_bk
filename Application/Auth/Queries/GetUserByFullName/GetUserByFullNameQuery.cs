using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Queries.GetUserByFullName
{
    public class GetUserByFullNameQuery : IRequest<User>
    {
        public string Name { get; }
        public string Surname { get; }

        public GetUserByFullNameQuery(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
