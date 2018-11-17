using System.Collections.Generic;
using GreenWalkApi.Models;

namespace GreenWalkApi.Services
{
    public interface IEventService
    {
        Event Get(int id);
        List<Event> GetAll();
        void Update(Event eventt);
        void Delete(Event eventt);
        void Create(Event eventt);
    }
}
