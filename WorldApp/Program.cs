using Shop.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorldApp.Models;

namespace WorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var appPath = Assembly.GetExecutingAssembly().Location;
            NHibernateHelper.Instance.Initialize(appPath.Substring(0, appPath.LastIndexOf("\\")));
        }
    }
}
