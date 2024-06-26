using AIPFramework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.User.Repositories;

namespace Task.Application.Models.User.Commands.CreateUser
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _userRepository.Create(new Domain.User.Entities.User(request.Name, request.Family, request.Age));

            return System.Threading.Tasks.Task.FromResult(_userRepository.Save() == 0 ? true : false);
        }
    }
}
