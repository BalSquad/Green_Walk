using GreenWalkApi.Models;
using System.Collections.Generic;

namespace GreenWalkApi.Services
{
    public interface ISuccessService
    {
        Success Get(int id);
        List<Success> GetAll();
        void Update(Success success);
        void Delete(Success success);
        void Create(Success success);

    }
}
