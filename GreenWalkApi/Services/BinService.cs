using System.Collections.Generic;
using System.Linq;
using GreenWalkApi.Models;
using GreenWalkModel;

namespace GreenWalkApi.Services
{
    public class BinService : IBinService
    {
        private GreenWalkContext _context;

        public BinService(GreenWalkContext context)
        {
            _context = context;
        }

        public void Delete(Bin bin)
        {
            _context.Remove(bin);
            _context.SaveChanges();
        }

        public Bin Get(int id)
        {
            return _context.Bins.Single<Bin>(b => b.BinID == id);
        }

        public List<Bin> GetAll()
        {
            return _context.Bins.ToList();
        }

        public void Update(Bin bin)
        {
            var _bin = _context.Bins.Find(bin.BinID);
            _bin = bin;
            _context.SaveChanges();
        }

        public void Create(Bin bin)
        {
            _context.Add(bin);
            _context.SaveChanges();
        }
    }
}
