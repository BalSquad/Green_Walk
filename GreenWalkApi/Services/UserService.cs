using GreenWalkApi.Models;
using GreenWalkModel;
using System.Collections.Generic;
using System.Linq;

namespace GreenWalkApi.Services
{
    public class UserService : IUserService
    {

        private GreenWalkContext _context;

        public UserService(GreenWalkContext context)
        {
            _context = context;
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public User Get(int id)
        {
            return _context.Users.Single(user => user.UserID == id);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Update(User user)
        {
            var _user = _context.Users.Find(user.UserID);
            _user = user;
            _context.SaveChanges();
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }

}