using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class Neutral : 
        IEntity, 
        ISpawnable, 
        IMovable
    {
        #region IEntity interface
        public virtual Guid ID { get; set; }
        #endregion

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int Level { get; set; }
        public virtual double Experience { get; set; }
        public virtual double Health { get; set; }
        public virtual double Mana { get; set; }

        public virtual bool IsAttackable { get; set; }
        public virtual bool IsAggressive { get; set; }
        public virtual bool IsImmortal { get; set; }
        public virtual bool IsImmobile { get; set; }
        public virtual double RespawnDelay { get; set; }

        public virtual Inventory Inventory { get; set; }

        #region ISpawnable interface
        public virtual double PositionX { get; set; }
        public virtual double PositionY { get; set; }
        #endregion

        #region IMovable interface
        public virtual double MovingDistance { get; set; }
        #endregion
    }
}
