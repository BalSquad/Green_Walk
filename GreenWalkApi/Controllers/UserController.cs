using System.Collections.Generic;
using GreenWalkApi.Interface;
using GreenWalkApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Controllers 
{
        [Route("api/[controller]")]
        [ApiController]
        public class UserController: ICRUDInterface<int>
        {

                private IUserService _userService;

                public UserController(IUserService userService) 
                {
                        _userService = userService;
                }

                [HttpGet]
                public int Get(int id) 
                {
                        return 1;
                }


                [HttpGet]
                public List<int> GetAll()
                {
                        return new List<int>();
                }

                [HttpPut]
                public void Update(int item)
                {

                }

                [HttpPost]
                public void Delete(int id)
                {

                }
        }

}