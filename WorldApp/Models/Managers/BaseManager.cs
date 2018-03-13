using Shop.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models.Managers
{
    class BaseManager<T> : IManager
        where T : class, IEntity
    {
        public System.Type EntityType
        {
            get
            {
                return typeof(T);
            }
        }

        public void CreateEntity(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEntity GetById(Guid id)
        {
            return NHibernateHelper.Instance.GetCurrentSession().Get<T>(id);
        }

        public IEnumerable<IEntity> GetLimt(int limit)
        {
            throw new NotImplementedException();
        }

        public void SaveEntity(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
