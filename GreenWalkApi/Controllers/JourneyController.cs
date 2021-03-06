using System.Collections.Generic;
using GreenWalkApi.Interface;
using GreenWalkApi.Models;
using GreenWalkApi.Services;
using GreenWalkModel;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyController : ControllerBase, ICRUD<Journey>
    {

        private IJourneyService _journeyService;

        public JourneyController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
        }

        [HttpPost]
        public void Create([FromBody]Journey item)
        {
            _journeyService.Create(item);
        }

        [HttpDelete]
        public void Delete([FromBody]Journey journey)
        {
            _journeyService.Delete(journey);
        }

        [HttpGet("{id}")]
        public ActionResult<Journey> Get(int id)
        {
            return _journeyService.Get(id);
        }

        [HttpGet("GetAllByUser/{id}")]
        public ActionResult<List<Journey>> GetAllByUser(int id)
        {
            return _journeyService.GetAllByUser(id);
        }

        [HttpGet]
        public ActionResult<List<Journey>> GetAll()
        {
            return _journeyService.GetAll();
        }

        [HttpPut]
        public void Update([FromBody]Journey journey)
        {
            _journeyService.Update(journey);
        }
    }

}