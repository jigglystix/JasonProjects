using CharacterTest.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTest
{
    public class CharacterObj : StandardDBFields
    {
        [StringLength(100)]
        public virtual string Name { get; set; }

        public virtual int ClassObjId { get; set; }
        public virtual ClassObj CharacterClass { get; set; }

        public virtual int RaceObjId { get; set; }
        public virtual RaceObj CharacterRace { get; set; }

        public virtual IList<InventoryObj> Items { get; set; }
    }
}
