using AIPFramework.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.Models.User.Queries.Common;
using Task.Domain.User.Repositories;

namespace Task.Application.Models.User.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUserById(request.Id);
            return System.Threading.Tasks.Task.FromResult(new UserViewModel(user.Id , user.Name , user.Family , user.Age));
        }
    }
}
