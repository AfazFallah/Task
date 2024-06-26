using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.User.Repositories;
using Task.Infra.Contexts;

namespace Task.Infra.Models.User.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskDbContext _context;

        public UserRepository(TaskDbContext context)
        {
            _context = context;
        }

        public int Create(Domain.User.Entities.User user)
        {
            var dbModel = Domain.User.Entities.User.Create(user.Name, user.Family, user.Age);
            _context.Users.Add(dbModel);
            _context.SaveChanges();
            return user.Id;
        }
        public void Delete(int id)
        {
            var user = GetUserById(id);
            user.IsDelete = true;
            _context.Users.Update(user);
            _context.SaveChanges();
        } 
        public void Update(Domain.User.Entities.User user)
        {
            var item = GetUserById(user.Id);
            user.ChangeName(item.Name);
            user.ChangeFamily(item.Family);
            user.ChangeAge(item.Age);
            _context.Update(user);
            _context.SaveChanges();
        }
        public List<Domain.User.Entities.User> GetAllUser()
        {
           var list =  _context.Users.ToList();
            return list;
        }
        public Domain.User.Entities.User GetUserById(int Id)
        {
            var item = _context .Users.FirstOrDefault(x => x.Id == Id);
            return item ?? new Domain.User.Entities.User();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
