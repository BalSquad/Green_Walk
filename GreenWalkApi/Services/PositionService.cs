using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenWalkApi.Models;

namespace GreenWalkApi.Services
{
    public class PositionService : IPositionService
    {

        private GreenWalkContext _context;

        public PositionService(GreenWalkContext context)
        {
            _context = context;
        }

        public void Delete(Position position)
        {
            _context.Remove(position);
            _context.SaveChanges();
        }

        public Position Get(int id)
        {
            return _context.Positions.Single(p => p.PositionID == id);
        }

        public List<Position> GetAll()
        {
            return _context.Positions.ToList();
        }

        public void Update(Position position)
        {
            var _position = _context.Positions.Find(position.PositionID);
            _position = position;
            _context.SaveChanges();
        }

        public void Create(Position position)
        {
            _context.Add(position);
            _context.SaveChanges();
        }
    }
}
