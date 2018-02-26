using Shop.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models.Managers
{
    public abstract class BaseManager<T>
        where T: class, IEntity
    {
        /// <summary>
        /// Вовзращает сущность по идентификатору.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T GetById(Guid id)
        {
            var session = NHibernateHelper.Instance.GetCurrentSession();
            if (session == null)
            {
                throw new Exception("Nhibernate session is null!");
            }
            return session.Get<T>(id);
        }
        /// <summary>
        /// Создает запись в базе данных внутри собственной транзакции. Запись сразу появится в базе данных.
        /// </summary>
        /// <param name="model"></param>
        public static void Create(T model)
        {
            var session = NHibernateHelper.Instance.GetCurrentSession();
            if (session == null)
            {
                throw new Exception("Nhibernate session is null!");
            }
            using (var tr = session.BeginTransaction())
            {
                try
                {
                    session.Save(model);
                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Записывает сущность в базу данных внутри внешней транзакции. Запись будет недоступна до тех пор, пока не будет вызвано сохранение транзакции.
        /// </summary>
        /// <param name="model"></param>
        public static void Add(T model)
        {
            var session = NHibernateHelper.Instance.GetCurrentSession();
            if (session == null)
            {
                throw new Exception("Nhibernate session is null!");
            }
            session.Save(model);
        }
        /// <summary>
        /// Возвращает все записи из базы данных
        /// </summary>
        /// <param name="limit">Максимальное количество записей</param>
        /// <returns></returns>
        public static IList<T> GetAll(int limit = -1)
        {
            var session = NHibernateHelper.Instance.GetCurrentSession();
            if (session == null)
            {
                throw new Exception("Nhibernate session is null!");
            }
            var criteria = session.CreateCriteria<T>();
            if (limit >= 0)
            {
                criteria = criteria.SetMaxResults(limit); ;
            }
            return criteria.List<T>();
        }
    }
}
