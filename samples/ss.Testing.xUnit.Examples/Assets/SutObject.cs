using System;
using System.Collections.Generic;
using System.Text;

namespace ss.Testing.xUnit.AutoNSubstitute.Example.Assets
{
    public class SutObject
    {
        public readonly ISutDepedency _dep;
        public SutObject(ISutDepedency dep)
        {
            _dep = dep;
        }

    }
}
