using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CharacterTest
{
    public class RaceObj : StandardDBFields
    {
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }

        public virtual int STRENGTH { get; set; }

        public virtual int AGILITY { get; set; }

        public virtual int VITALITY { get; set; }

        public virtual int INTELLIGENCE { get; set; }

        public virtual int DEXTERITY { get; set; }
    }
}
