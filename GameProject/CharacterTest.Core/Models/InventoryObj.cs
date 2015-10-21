using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTest
{
    public class InventoryObj : StandardDBFields
    {
        public virtual int CharacterObjId { get; set; }

        public virtual int ItemObjId { get; set; }
        public virtual ItemObj BaseObject { get; set; }

        public virtual string ItemName { get; set; }

        public virtual bool IsConsumable { get; set; }

        public virtual bool IsEquippable { get; set; }

        public virtual int Weight { get; set; }

        public virtual int STRModify { get; set; }

        public virtual int AGIModify { get; set; }

        public virtual int VITModify { get; set; }

        public virtual int INTModify { get; set; }

        public virtual int DEXModify { get; set; }

        public virtual int Count { get; set; }
    }
}
