using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Core;
using System.Data.Entity;

namespace CharacterTest.Core.DataAccess
{
    public class ItemService
    {
        private readonly DbContext _context;
        private readonly IGenericRepository<ItemObj> _itemRepo;

        public ItemService(DbContext context)
        {
            _context = context;
            _itemRepo = new GenericRepository<ItemObj>(_context);
        }

        public void Insert(ItemObj itemAdd)
        {
            if (itemAdd != null)
            {
                _itemRepo.Insert(itemAdd);
                _context.SaveChanges();
            }
        }
    }
}
