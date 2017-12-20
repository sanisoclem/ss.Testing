using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ss.Testing.xUnit.AutoMoq
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(new Fixture().Customize(new AutoConfiguredMoqCustomization()))
        {

        }
        protected AutoMoqDataAttribute(IFixture fixture)
            :base(fixture.Customize(new AutoConfiguredMoqCustomization()))
        {

        }
    }
}
