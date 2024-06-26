using AIPFramework.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.User.Repositories;

namespace Task.Application.Models.User.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand , bool>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        Task<bool> IRequestHandler<DeleteUserCommand, bool>.Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            _userRepository.Delete(request.Id);
            _userRepository.Save();
            return System.Threading.Tasks.Task.FromResult(_userRepository.Save() == 0 ? true : false);
        }
    }
}
