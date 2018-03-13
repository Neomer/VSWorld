using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models
{
    /// <summary>
    /// Описание нейтрального существа мира
    /// </summary>
    public class Neutral : 
        IEntity,
        ISpawnable,
        IMovable
    {
        #region IEntity interface
        public virtual Guid ID { get; set; }
        #endregion

        #region ISpawnable interface
        public virtual double SpawnX { get; set; }
        public virtual double SpawnY { get; set; }
        #endregion

        #region IMovable interface
        public virtual double MovingDistance { get; set; }
        #endregion
        /// <summary>
        /// Наименование
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// Уровень
        /// </summary>
        public virtual int Level { get; set; }
        /// <summary>
        /// Количество  опыта за убийство
        /// </summary>
        public virtual double Experience { get; set; }
        /// <summary>
        /// Количество здоровья
        /// </summary>
        public virtual double Health { get; set; }
        /// <summary>
        /// Количество маны
        /// </summary>
        public virtual double Mana { get; set; }
        /// <summary>
        /// Максимальное количество особей в популяции
        /// </summary>
        public virtual int Population { get; set; }
        /// <summary>
        /// Атакуемый
        /// </summary>
        public virtual bool IsAttackable { get; set; }
        /// <summary>
        /// Агрессивный
        /// </summary>
        public virtual bool IsAggressive { get; set; }
        /// <summary>
        /// Бессмертный
        /// </summary>
        public virtual bool IsImmortal { get; set; }
        /// <summary>
        /// Обездвиженный
        /// </summary>
        public virtual bool IsImmobile { get; set; }
        /// <summary>
        /// Инвентарь существа
        /// </summary>
        public virtual Inventory Inventory { get; set; }
    }
}
