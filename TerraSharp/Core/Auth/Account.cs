using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraSharp.Globals;

namespace TerraSharp.Core.Auth
{
    public abstract class Account
    {
        //Prototype Functions
        //
        //TODO: Complete functions based on Added Import Declarations
        //

        public bool fromAmino(object amino, bool? isClassic)
        {
            switch(amino)
            {
                default:
                    return false;
            }
        }

        public bool fromData(object data, bool? isClassic)
        {
            switch (data)
            {
                default:
                    return false;
            }
        }

        public bool fromProto(object proto, bool? isClassic)
        {
            switch (proto)
            {
                default:
                    return false;
            }
        }
    }
}
