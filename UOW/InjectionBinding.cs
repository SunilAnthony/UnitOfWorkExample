using Ninject.Modules;
using System;
using UOW.BAL;
using UOW.DAL;

namespace UOW
{
    public class InjectionBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<PlutoContext>();
        }
    }
}
