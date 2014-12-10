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
        //private string _name;
        //public void SetName(string name)
        //{
        //    _name = name;
        //}
        //public string GetName()
        //{
        //    return _name;
        //}

        //public virtual string Name 
        //{
        //    get
        //    {
        //        return _name;
        //    }
            
        //    set
        //    {
        //        if (_name.Length > 5)
        //            _name = "Too long";
        //        else
        //            _name = value;
        //    }
        //}

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
