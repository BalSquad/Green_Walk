namespace GreenWalkApi.Services 
{
        public interface IJourneyService 
        {
                int Get(int id);
                int GetAll();
                void Update();
                void Delete(int id);
        }

}