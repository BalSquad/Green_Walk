using System.Collections.Generic;
using System.Linq;
using GreenWalkApi.Models;
using GreenWalkModel;

namespace GreenWalkApi.Services
{
    public class EventService : IEventService
    {

        private GreenWalkContext _context;

        public EventService(GreenWalkContext context)
        {
            _context = context;
        }
        
        public void Delete(Event eventt)
        {
            _context.Remove(eventt);
            _context.SaveChanges();
        }

        public Event Get(int id)
        {
            return _context.Events.Single(e => e.EventID == id);
        }

        public List<Event> GetAll()
        {
            return _context.Events.ToList();
        }

        public void Update(Event eventt)
        {
            var _event = _context.Events.Find(eventt.EventID);
            _event = eventt;
            _context.SaveChanges();
        }

        public void Create(Event eventt)
        {
            _context.Add(eventt);
            _context.SaveChanges();
        }
    }
}
