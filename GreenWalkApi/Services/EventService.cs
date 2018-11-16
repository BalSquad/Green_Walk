using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenWalkApi.Services
{
    public class EventService : IEventService
    {

        private IContextService _contextService;

        public EventService(IContextService contextService)
        {
            _contextService = contextService;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Get(int id)
        {
            throw new NotImplementedException();
        }

        public int GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
