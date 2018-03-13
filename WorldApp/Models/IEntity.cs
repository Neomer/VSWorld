using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    /// <summary>
    /// Сущность, имеющая идентификатор
    /// </summary>
    public interface IEntity
    {
        Guid ID { get; set; }
    }
}
