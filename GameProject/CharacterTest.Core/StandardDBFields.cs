using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterTest
{
    public abstract class StandardDBFields
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual DateTime CreatedUtc { get; set; }

        [StringLength(100)]
        public virtual string CreatedBy { get; set; }

        public virtual DateTime? LastModifiedUTC { get; set; }

        [StringLength(100)]
        public virtual string LastModifiedBy { get; set; }
    }
}
