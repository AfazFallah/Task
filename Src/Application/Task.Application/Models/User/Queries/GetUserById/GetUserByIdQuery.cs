using AIPFramework.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.Models.User.Queries.Common;

namespace Task.Application.Models.User.Queries.GetUserById
{
    public class GetUserByIdQuery : IQuery<UserViewModel>
    {
        public int Id { get; set; }
    }
}
