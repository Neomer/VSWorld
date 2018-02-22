using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class InventoryItem
    {
        public virtual Inventory Inventory { get; set; }
        public virtual double Count { get; set; }
        public virtual bool IsEqipped { get; set; }
    }
}
