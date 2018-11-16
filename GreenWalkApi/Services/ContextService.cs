namespace GreenWalkApi.Services 
{

    public class ContextService: IContextService 
    {
        private int _context;

        public int Context
        {
            get
            {
                return _context;
            }
        }

        public ContextService(int context)
        {
            _context = context;
        }

    }


}