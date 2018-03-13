using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public class Skill 
    {
        public virtual Guid ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Effect Effect { get; set; }
    }
}
