using Example.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Example
{
    public class LinuxOS : IAbstractSpecificOS
    {
        public object GetSpecification() => new 
        {
            Description = RuntimeInformation.OSDescription,
            Architecture = RuntimeInformation.OSArchitecture,
            Linux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
        };
    }
}
