using Example.Contracts;
using System;

namespace Example
{
    public class Main
    {
        private readonly IAbstractFactoryOS _abstractFactoryOS;

        public Main(IAbstractFactoryOS abstractFactory)
        {
            _abstractFactoryOS = abstractFactory;
        }

        public void GetSpecification() => _abstractFactoryOS.GetSpecificOS();
    }
}
