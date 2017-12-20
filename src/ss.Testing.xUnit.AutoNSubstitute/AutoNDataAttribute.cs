using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ss.Testing.xUnit.AutoNSubstitute
{
    public class AutoNDataAttribute : AutoDataAttribute
    {
        public AutoNDataAttribute()
            : base(new Fixture().Customize(new AutoConfiguredNSubstituteCustomization()))
        {

        }
        protected AutoNDataAttribute(IFixture fixture)
            :base(fixture.Customize(new AutoConfiguredNSubstituteCustomization()))
        {

        }
    }
}
