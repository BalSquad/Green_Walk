using GreenWalkApi.Models;
using GreenWalkModel;
using System.Collections.Generic;
using System.Linq;

namespace GreenWalkApi.Services
{

    public class JourneyService : IJourneyService
    {

        private GreenWalkContext _context;

        public JourneyService(GreenWalkContext context)
        {
            _context = context;
        }

        public void Delete(Journey journey)
        {
            _context.Remove(journey);
            _context.SaveChanges();
        }

        public Journey Get(int id)
        {
            return _context.Journeys.Single(journey => journey.JourneyID == id);
        }

        public List<Journey> GetAll()
        {
            return _context.Journeys.ToList();
        }

        public List<Journey> GetAllByUser(int id)
        {
            return _context.Journeys
                .Where(journey => journey.UserID == id)
                .ToList();
        }

        public void Update(Journey journey)
        {
            var _journey = _context.Journeys.Find(journey.JourneyID);
            _journey = journey;
            _context.SaveChanges();
        }

        public void Create(Journey journey)
        {
            _context.Journeys.Add(journey);
            _context.SaveChanges();
        }
    }

}