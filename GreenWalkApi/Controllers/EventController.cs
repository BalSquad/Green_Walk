using System;
using System.Collections.Generic;
using GreenWalkApi.Interface;
using GreenWalkApi.Models;
using GreenWalkApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class EventController : ControllerBase, ICRUD<Event>
    {
        private IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public void Create([FromBody]Event eventt)
        {
            _eventService.Create(eventt);
        }

        [HttpPost]
        public void Delete([FromBody]Event eventt)
        {
            _eventService.Delete(eventt);
        }

        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            return _eventService.Get(id);
        }

        [HttpGet]
        public ActionResult<List<Event>> GetAll()
        {
            return _eventService.GetAll();
        }

        [HttpPut]
        public void Update([FromBody]Event eventt)
        {
            _eventService.Update(eventt);
        }
    }

}
