using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenWalkApi.Interface;
using GreenWalkApi.Models;
using GreenWalkApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreenWalkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuccessController : ControllerBase, ICRUD<Success>
    {
        private ISuccessService _successService;

        public SuccessController(ISuccessService successService)
        {
            _successService = successService;
        }

        [HttpPost]
        public void Create([FromBody]Success success)
        {
            _successService.Create(success);
        }

        [HttpDelete]
        public void Delete([FromBody]Success success)
        {
            _successService.Delete(success);
        }

        [HttpGet("{id}")]
        public ActionResult<Success> Get(int id)
        {
            return _successService.Get(id);
        }

        [HttpGet]
        public ActionResult<List<Success>> GetAll()
        {
            return _successService.GetAll();
        }

        [HttpPut]
        public void Update([FromBody]Success success)
        {
            _successService.Update(success);
        }
    }
}
