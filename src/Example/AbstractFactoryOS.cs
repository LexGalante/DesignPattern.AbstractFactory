using Example.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Example
{
    public abstract class AbstractFactoryOS : IAbstractFactoryOS
    {
        public IAbstractSpecificOS GetSpecificOS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return new MicrosoftOS();
            else
                return new LinuxOS();
        }
    }
}
