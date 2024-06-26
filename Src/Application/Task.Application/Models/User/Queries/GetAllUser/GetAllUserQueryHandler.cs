using AIPFramework.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.Models.User.Queries.Common;
using Task.Domain.User.Entities;
using Task.Domain.User.Repositories;

namespace Task.Application.Models.User.Queries.GetAllUser
{
    public class GetAllUserQueryHandler : IQueryHandler<GetAllUserQuery, List<UserViewModel>>
    {
        private readonly IUserRepository _userRepository;
        public GetAllUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<List<UserViewModel>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetAllUser();
            if (!string.IsNullOrEmpty(request.Search) && request.Search!="string") 
            {
                users = users.Where(t => t.Name.Contains(request.Search) || t.Family.Contains(request.Search)).ToList();
            }
            var userViews = users.Select(t => new UserViewModel(t.Id, t.Name, t.Family, t.Age)).Skip(request.SkipCount).Take(request.PageSize).ToList();
            return System.Threading.Tasks.Task.FromResult(userViews);
        }
    }
}
