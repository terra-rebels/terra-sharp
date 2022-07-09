using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Ioc;
using Prism.Events;
using TerraSharp.Client.Lcd;

namespace TerraSharp
{
    public class TerraStartup : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();

            // Api Configuration
            this.Bind<APIRequester>().ToConstructor((e) => new APIRequester(""));
        }
    }
}
