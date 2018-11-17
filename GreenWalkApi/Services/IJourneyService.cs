using GreenWalkModel;
using System.Collections.Generic;

namespace GreenWalkApi.Services
{
    public interface IJourneyService
    {
        Journey Get(int id);
        List<Journey> GetAll();
        List<Journey> GetAllByUser(int id);
        void Update(Journey journey);
        void Delete(Journey journey);
        void Create(Journey journey);
    }

}