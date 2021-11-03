using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneDictionary;
using DB_JSON;
using DB_MSSQL;
using Ninject.Web.Common;

namespace lab6.Config
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneDictionary<Phone>>().To<DB_MSSQL.PhoneRepository>();

            //Bind<IPhoneDictionary<Phone>>().To<DB_JSON.PhoneRepository>().InSingletonScope(); 

            //Bind<IPhoneDictionary<Phone>>().To<DB_MSSQL.PhoneRepository>().InThreadScope(); 

            //Bind<IPhoneDictionary<Phone>>().To<DB_JSON.PhoneRepository>().InRequestScope();
        }
    }
}