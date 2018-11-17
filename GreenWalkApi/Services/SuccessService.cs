using GreenWalkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenWalkApi.Services
{
    public class SuccessService: ISuccessService
    {

        private GreenWalkContext _context;

        public SuccessService(GreenWalkContext context)
        {
            _context = context;
        }

        public void Create(Success success)
        {
            _context.Successes.Add(success)
        }

        public void Delete(Success success)
        {
            _context.Remove(success);
            _context.SaveChanges();
        }

        public Success Get(int id)
        {
            return _context.Successes.Single(success => success.SuccessID == id);
        }

        public List<Success> GetAll()
        {
            return _context.Successes.ToList();
        }

        public void Update(Success success)
        {
            var _success = _context.Successes.Single(item => item.SuccessID == success.SuccessID);
            _success = success;
            _context.SaveChanges();
        }
    }
}
