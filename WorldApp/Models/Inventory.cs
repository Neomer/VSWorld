using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class Inventory : IEntity
    {
        public virtual Guid ID { get; set; }
        public virtual Hero Owner { get; set; }
        public virtual double WeightLimit { get; set; }
        public virtual double ItemsLimit { get; set; }

        public virtual IList<InventoryItem> Items { get; set; }
    }
}
