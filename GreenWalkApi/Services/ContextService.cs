using GreenWalkApi.Models;

namespace GreenWalkApi.Services
{

    public class ContextService : IContextService
    {
        private readonly GreenWalkContext _context;

        public GreenWalkContext Context => _context;

        public ContextService(GreenWalkContext context)
        {
            _context = context;
        }

    }


}