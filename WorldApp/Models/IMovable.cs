using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    /// <summary>
    /// Объект, перемещающийся на определенное расстояние.
    /// </summary>
    public interface IMovable
    {
        /// <summary>
        /// Максимальная дистанция, на которую существо может переместиться
        /// </summary>
        double MovingDistance { get; set; }
    }
}
