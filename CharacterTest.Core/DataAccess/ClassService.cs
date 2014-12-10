using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Repository.Core;
using CharacterTest.Core.Models;

namespace CharacterTest.Core.DataAccess
{
    public class ClassService
    {
            private readonly DbContext _context;
            private readonly IGenericRepository<ClassObj> _classRepo;



            public ClassService(DbContext context)
            {
                _context = context;
                _classRepo = new GenericRepository<ClassObj>(_context);
            }

            public void Insert(ClassObj classAdd)
            {
                if (classAdd != null)
                {
                    _classRepo.Insert(classAdd);
                    _context.SaveChanges();
                }
            }
        }
}
