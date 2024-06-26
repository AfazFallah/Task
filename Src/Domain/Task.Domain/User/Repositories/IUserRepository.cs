using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domain.User.Repositories
{
    public interface IUserRepository
    {
        int Create(Entities.User user);
        void Update(Entities.User user);
        void Delete(int id);
       List<Entities.User> GetAllUser();
        Entities.User GetUserById(int Id);
        int Save();
    }
}
