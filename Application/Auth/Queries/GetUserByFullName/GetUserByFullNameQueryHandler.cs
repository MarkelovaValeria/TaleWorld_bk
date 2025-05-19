using Domain.Entities;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Queries.GetUserByFullName
{
    public class GetUserByFullNameQueryHandler : IRequestHandler<GetUserByFullNameQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByFullNameQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByFullNameQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserByFullNameAsync(request.Name, request.Surname);
        }
    }
}
