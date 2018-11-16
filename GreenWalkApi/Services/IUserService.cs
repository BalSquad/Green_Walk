namespace GreenWalkApi.Services
{
        public interface IUserService
        {            
                int Get(int id);
                int GetAll();
                void Update();
                void Delete();
        }

}