using Ploeh.AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ss.Testing.xUnit.Utils
{
    public class IgnoreVirtualMemberSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var pi = request as PropertyInfo;
            if (pi == null)
            {
                return new NoSpecimen();
            }

            if (pi.GetGetMethod().IsVirtual)
            {
                return null;
            }
            return new NoSpecimen();
        }
    }
}
