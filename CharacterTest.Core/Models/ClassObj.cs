using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTest.Core.Models
{
    public class ClassObj : StandardDBFields
    {
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }

        public virtual int STRModifier { get; set; }

        public virtual int AGIModifier { get; set; }

        public virtual int VITModifier { get; set; }

        public virtual int INTModifier { get; set; }

        public virtual int DEXModifier { get; set; }

        public virtual IList<ItemObj> ExcludedItems { get; set; }

    }
}
