using System.Collections.Generic;
using GreenWalkApi.Interface;
using GreenWalkApi.Services;
using GreenWalkModels;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class BinController : ControllerBase, ICRUD<Bin>
    {
        private IBinService _binService;

        public BinController(IBinService binService)
        {
            _binService = binService;
        }

        [HttpPost]
        public void Create([FromBody]Bin bin)
        {
            _binService.Create(bin);
        }

        [HttpPost]
        public void Delete([FromBody]Bin bin)
        {
            _binService.Delete(bin);
        }

        [HttpGet("{id}")]
        public ActionResult<Bin> Get(int id)
        {
            return _binService.Get(id);
        }

        [HttpGet]
        public ActionResult<List<Bin>> GetAll()
        {
            return _binService.GetAll();
        }

        [HttpPut]
        public void Update([FromBody]Bin bin)
        {
            _binService.Update(bin);
        }
    }
}
