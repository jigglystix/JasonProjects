using Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CharacterTest.Core.DataAccess
{
    public class RaceService
    {
        private readonly DbContext _context;
        private readonly IGenericRepository<RaceObj> _raceRepo;

        

        public RaceService(DbContext context) 
        {
            _context = context;
            _raceRepo = new GenericRepository<RaceObj>(_context);
        }

        public void Insert(RaceObj raceAdd)
        {
            if (raceAdd != null)
            {
                _raceRepo.Insert(raceAdd);
                _context.SaveChanges();
            }
        }
    }
}
