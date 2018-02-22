using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class Hero : IEntity
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Skill> Skills { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Race Race { get; set; }
    }
}
