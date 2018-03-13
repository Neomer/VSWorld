using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Models.Managers
{
    public class ManagerFactory
    {
        #region Singleton
        private static ManagerFactory _instance;
        public static ManagerFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManagerFactory();
                }
                return _instance;
            }
        }
        #endregion

        IList<IManager> _list;

        private ManagerFactory()
        {
            _list = new List<IManager>();
        }

        public void Register(IManager manager)
        {
            var mgr = _list.FirstOrDefault(p => p.EntityType == manager.EntityType);
            if (mgr != null)
            {
                throw new Exception("Менеджер для сущности указанного типа уже зарегистрирован!");
            }
            _list.Add(manager);
        }

        public IManager GetManager(System.Type type)
        {
            return _list.FirstOrDefault(p => p.EntityType == type);
        }
    }
}
