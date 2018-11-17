using System.Collections.Generic;
using GreenWalkApi.Models;

namespace GreenWalkApi.Services
{
    public interface IPositionService
    {
        void Delete(Position position);
        Position Get(int id);
        List<Position> GetAll();
        void Update(Position position);

        void Create(Position position);
    }
}
