using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Application.Models.User.Queries.Common
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        public UserViewModel(int id, string name, string family, int age)
        {
            Id = id;
            Name = name;
            Family = family;
            Age = age;
        }
    }
}
