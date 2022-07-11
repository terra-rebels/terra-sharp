using Ninject;
using System.Reflection;

namespace TerraSharp
{
    public static class TerraStartup
    {
        public static StandardKernel Kernel { get; set; }

        public static void InitializeKernel()
        {
            Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static T GetService<T>()
        {
            return Kernel.Get<T>();
        }

        public static IEnumerable<T> GetServices<T>()
        {
            return Kernel.GetAll<T>();
        }
    }
}
