using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class Neutral : IEntity
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int Level { get; set; }
        public virtual double Experience { get; set; }
        public virtual double Health { get; set; }
        public virtual double Mana { get; set; }

        public virtual bool IsAttackable { get; set; }
        public virtual bool IsAggressive { get; set; }
        public virtual bool IsImmortal { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
