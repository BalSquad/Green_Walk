using System.Collections.Generic;
using GreenWalkApi.Interface;
using GreenWalkApi.Services;

namespace GreenWalkApi.Controllers 
{

        public class JourneyController : ICRUDInterface<int>
        {

                private IJourneyService _journeyService;

                public JourneyController(IJourneyService journeyService)
                {
                        _journeyService = journeyService;
                }

                public void Delete(int id)
                {
                        _journeyService.Delete(id);
                }

                public int Get(int id)
                {
                        throw new System.NotImplementedException();
                }

                public List<int> GetAll()
                {
                        throw new System.NotImplementedException();
                }

                public void Update(int item)
                {
                        throw new System.NotImplementedException();
                }
        }

}