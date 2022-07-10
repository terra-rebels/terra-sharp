using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Extension
{
    public class Extension
    {
    }

    public static class NinjectContainerExtensions
    {
        public IKernel GetContainer()
        {
            return IKernel kernel = new StandardKernel();
            var samurai = kernel.Get<Samurai>();
        }
    }
}
