using System.Collections.Generic;
using GreenWalkApi.Models;

namespace GreenWalkApi.Services
{
    public interface IBinService
    {
        void Delete(Bin bin);
        Bin Get(int id);
        List<Bin> GetAll();
        void Update(Bin bin);

        void Create(Bin bin);
    }

}