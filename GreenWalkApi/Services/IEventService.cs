namespace GreenWalkApi.Services
{
    public interface IEventService
    {
        int Get(int id);
        int GetAll();
        void Update();
        void Delete(int id);
    }
}
