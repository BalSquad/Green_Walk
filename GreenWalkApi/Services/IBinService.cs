namespace GreenWalkApi.Services
{
        public interface IBinService
        {            
                int Get(int id);
                int GetAll();
                void Update();
                void Delete();
        }

}