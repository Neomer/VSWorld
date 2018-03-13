using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldApp.Models.Managers;

namespace WorldApp.Models
{
    /// <summary>
    /// Сущность, имеющая идентификатор
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Guid ID { get; set; }
        /// <summary>
        /// Менеджер доступа к сущности
        /// </summary>
        IManager Manager { get; }
    }
}
