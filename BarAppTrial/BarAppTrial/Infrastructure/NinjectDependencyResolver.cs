using System;
using BarAppTrial.Repositories;
using BarAppTrial.EntFramWk;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace BarAppTrial.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IDrinksRepository>().To<EFDrinkRepository>();
        }
    }
}