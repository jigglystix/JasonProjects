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

            public ClassObj SelectbyId(int Id)
            {

                // Returns for specific or defaults. Breaks if duplicate entries
                return _classRepo.Table.Where(x => x.Id == Id).SingleOrDefault();

                /* For duplicate results, however because filtering by ID, not necessary
                ClassObj result = null;
                IList<ClassObj> items =_classRepo.Table.Where(x => x.Id == Id).ToList();
                foreach (var item in items)
                    result = item;

                return result;
                */
            }

            public IList<ClassObj> SelectAll()
            {
                //var queryClass = from c in _classRepo.Table
                //                 select c;
                //return queryClass.ToList();

                return _classRepo.Table.ToList();
            }
        }
}
