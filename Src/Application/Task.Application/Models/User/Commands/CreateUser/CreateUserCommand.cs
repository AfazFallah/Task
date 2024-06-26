using AIPFramework.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task.Application.Models.User.Commands.CreateUser
{
    public class CreateUserCommand : ICommand<bool>
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public CreateUserCommand(string name, string family, int age)
        {
            Name = name;
            Family = family;
            Age = age;
        }
    }
}
