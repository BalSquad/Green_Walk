namespace GreenWalkApi.Services 
{

        public class JourneyService: IJourneyService
        {

                private IContextService _context;

                public JourneyService(IContextService context) 
                {
                        _context = context;
                }

                public void Delete(int id)
                {
                        throw new System.NotImplementedException();
                }

                public int Get(int id)
                {
                        throw new System.NotImplementedException();
                }

                public int GetAll()
                {
                        throw new System.NotImplementedException();
                }

                public void Update()
                {
                        throw new System.NotImplementedException();
                }
        }

}