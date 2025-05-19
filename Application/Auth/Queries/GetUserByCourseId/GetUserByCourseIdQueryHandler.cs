using Domain.Entities;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Queries.GetUserByCourseId
{
    public class GetUserByCourseIdQueryHandler : IRequestHandler<GetUserByCourseIdQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByCourseIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByCourseIdQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetTeacherByCourseIdAsync(request.CourseId);
        }
    }
}
