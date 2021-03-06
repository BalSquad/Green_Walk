using GreenWalkModel;
using System.Collections.Generic;

namespace GreenWalkApi.Services
{
    public interface IUserService
    {
        User Get(int id);
        List<User> GetAll();
        void Update(User user);
        void Delete(User user);
        void Create(User user);
    }

}