using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTest
{
    public class StatsObj
    {
        private ClassObj _c;
        private RaceObj _r;
        public int RaceId { get; set; }

        private int _str;
        private int _agi;
        private int _vit;
        private int _int;
        private int _dex;

        public StatsObj()
            : this(new ClassObj(), new RaceObj())
        {
        }

        public StatsObj(ClassObj c, RaceObj r)
        {
            _c = c;
            _r = r;
        }

        public virtual ClassObj ClassObject
        {
            get { return _c; }
            set { _c = value; }
        }

        public virtual RaceObj RaceObject
        {
            get { return _r; }
            set { _r = value; }
        }

        public virtual int STRENGTH { 
            get 
            {
                return _c.STRModifier + _r.STRENGTH;
            }
        }

        public virtual int AGILITY { 
            get 
            {
                return _c.AGIModifier + _r.AGILITY;
            }
        }

        public virtual int VITALITY { 
            get 
            {
                return _c.VITModifier + _r.VITALITY;
            }
        }

        public virtual int INTELLIGENCE { 
            get 
            {
                return _c.INTModifier + _r.INTELLIGENCE;
            }
        }

        public virtual int DEXTERITY { 
            get 
            {
                return _c.DEXModifier + _r.DEXTERITY;
            }
        }
    }
}
