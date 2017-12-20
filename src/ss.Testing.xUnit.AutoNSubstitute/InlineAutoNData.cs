using Ploeh.AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ss.Testing.xUnit.AutoNSubstitute
{
    public class InlineAutoNDataAttribute : InlineAutoDataAttribute
    {
        public InlineAutoNDataAttribute(params object[] values)
            : base(new AutoNDataAttribute(), values)
        {

        }
    }
}
