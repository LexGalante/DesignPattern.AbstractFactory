using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Contracts
{
    public interface IAbstractFactoryOS
    {
        IAbstractSpecificOS GetSpecificOS();
    }
}
