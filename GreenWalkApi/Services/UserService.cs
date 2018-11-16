namespace GreenWalkApi.Services 
{
        public class UserService: IUserService {

                private IContextService _context;

                public UserService(IContextService context) {
                        _context = context;
                }

                public void Delete()
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