using AIPFramework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.Models.User.Queries.Common;

namespace Task.Application.Models.User.Commands.UpdateUser
{
    public class UpdateUserCommand : UserViewModel , ICommand<bool> 
    {
        public UpdateUserCommand(int id, string name, string family, int age) : base(id, name, family, age)
        {

        }
    }
}
