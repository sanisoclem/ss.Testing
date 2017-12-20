using Ploeh.AutoFixture.Xunit2;
using System;

namespace ss.Testing.xUnit.AutoMoq
{
    public class InlineAutoMoqDataAttribute : InlineAutoDataAttribute
    {
        public InlineAutoMoqDataAttribute(params object[] values)
            : base(new AutoMoqDataAttribute(), values)
        {

        }
    }
}
