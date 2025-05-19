using Domain.Entities;
using Domain.Entities.Enum;
using Domain.Interfaces;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, bool>
    {
        private readonly IPassWordHasher _passWordHasher;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IPassWordHasher passWordHasher, IUserRepository userRepository)
        {
            _passWordHasher = passWordHasher;
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {

            var existingUser = await _userRepository.GetUserByEmailAsync(request.Email);
            if (existingUser != null)
                return false;

            var hashedPassword = _passWordHasher.Generate(request.Password);

            var user = new User
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                PasswordHash = hashedPassword,
                Role = request.Role,
                TeachingLanguage = request.Language
            };
            user.Validate();
            await _userRepository.AddUserAsync(user);
            return true;
        }
    }
}
