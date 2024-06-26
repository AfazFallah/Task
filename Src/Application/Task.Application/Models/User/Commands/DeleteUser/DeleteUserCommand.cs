using AIPFramework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task.Application.Models.User.Commands.DeleteUser
{
    public class DeleteUserCommand : ICommand<bool>
    {
        public int Id { get; set; }
    }
}
