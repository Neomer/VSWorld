using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    public interface ISpawnable
    {
        /// <summary>
        /// Позиция для возрождения. X координата.
        /// </summary>
        double SpawnX { get; set; }
        /// <summary>
        /// Позиция для возрождения. Y координата.
        /// </summary>
        double SpawnY { get; set; }
    }
}
