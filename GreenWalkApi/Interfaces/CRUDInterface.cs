using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Interface
{

        public interface ICRUDInterface<T>
        {
            
                [HttpGet]
                T Get(int id);

                [HttpGet]
                List<T> GetAll();

                [HttpPut]
                void Update(T item);

                [HttpPost]
                void Delete(int id);

        }

}