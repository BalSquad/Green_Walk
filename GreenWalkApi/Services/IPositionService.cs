namespace GreenWalkApi.Services
{
    public interface IPositionService
    {
        int Get(int id);
        int GetAll();
        void Update();
        void Delete(int id);
    }
}
