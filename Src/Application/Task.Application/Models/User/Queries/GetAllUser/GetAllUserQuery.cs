using AIPFramework.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.Models.User.Queries.Common;
using Task.Domain.User.Repositories;

namespace Task.Application.Models.User.Queries.GetAllUser
{
    public class GetAllUserQuery : PageQuery<List<UserViewModel>>
    {
        public string? Search { get; set; } = string.Empty;
    }
}
