using Example.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Example
{
    public class MicrosoftOS : IAbstractSpecificOS
    {
        public object GetSpecification() => new
        {
            Description = RuntimeInformation.OSDescription,
            Architecture = RuntimeInformation.OSArchitecture,
            Windows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
        };
    }
}
