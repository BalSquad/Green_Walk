using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GreenWalkApi.Interface
{

    public interface ICRUDInterface<T>
    {

        [HttpGet]
        ActionResult<T> Get(int id);

        [HttpGet]
        ActionResult<List<T>> GetAll();

        [HttpPut]
        void Update(T item);

        [HttpPost]
        void Delete(T id);

    }

}