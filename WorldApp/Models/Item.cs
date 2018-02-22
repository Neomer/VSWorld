using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class Item : IEntity
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual double Weight { get; set; }
        public virtual Slot EqipSlot { get; set; }
        public virtual Type Type { get; set; }

        public virtual bool IsStackable { get; set; }
        public virtual bool IsDestroyable { get; set; }
        public virtual bool IsDroppable { get; set; }
        public virtual bool IsEquippable { get; set; }
    }

    public enum Slot
    {
        None,
        BothHand,
        RightHand,
        LeftHand,
        Head,
        Body,
        Legs
    }

    public enum Type
    {
        Resource, 
        Weapon,
        Armor
    }
}
