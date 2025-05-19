using Domain.Interfaces;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPassWordHasher _passwordHasher;
        private readonly IJwtProvider _jwtProvider;

        public LoginCommandHandler(IUserRepository userRepository, IPassWordHasher passWordHasher, IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _passwordHasher = passWordHasher;
            _jwtProvider = jwtProvider;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAsync(request.Email);

            var result = _passwordHasher.Verify(request.Password, user.PasswordHash);
            if (result == false)
            {
                throw new Exception("Неправильний пароль");
            }
            Console.WriteLine(user.Email);
            var token = _jwtProvider.GenerateToken(user);
            return token;
        }
      

    }
}
