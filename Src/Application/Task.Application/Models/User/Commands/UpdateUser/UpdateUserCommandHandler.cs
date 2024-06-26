using AIPFramework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.User.Repositories;

namespace Task.Application.Models.User.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUserById(request.Id);
            user.ChangeName(request.Name);
            user.ChangeFamily(request.Family);
            user.ChangeAge(request.Age);
            _userRepository.Update(user);
            return System.Threading.Tasks.Task.FromResult(_userRepository.Save() == 0 ? true : false);
        }
    }
}
