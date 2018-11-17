using System.Collections.Generic;
using GreenWalkApi.Interface;
using GreenWalkApi.Models;
using GreenWalkApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase, ICRUDInterface<User>
    {

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _userService.Get(id);
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpPut]
        public void Update(User user)
        {
            _userService.Update(user);
        }

        [HttpPost]
        public void Delete(User user)
        {
            _userService.Delete(user);
        }

        [HttpPost]
        public void Create(User item)
        {
            throw new System.NotImplementedException();
        }
    }

}