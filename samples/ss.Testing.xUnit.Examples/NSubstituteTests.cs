using System;
using NSubstitute;
using Ploeh.AutoFixture.Xunit2;
using ss.Testing.xUnit.AutoNSubstitute;
using ss.Testing.xUnit.AutoNSubstitute.Example.Assets;
using Xunit;

namespace ss.Testing.xUnit.AutoNSubstitute.Example
{
    public class NSubstituteTests
    {
        [Theory]
        [AutoNData]
        public void AutoNDataTest(
           string someString,
           [Frozen] ISutDepedency dep,
           SutObject sut)
        {
            // -- arrange
            dep.GetSomething().ReturnsForAnyArgs(someString);

            // -- act
            var result = sut._dep.GetSomething();

            // -- assert
            Assert.Equal(someString, result);
        }


        [Theory]
        [InlineAutoNData("someuniquestring")]
        public void InlineAutoNDataTest(
            string uniquestring,
            [Frozen] ISutDepedency dep,
            SutObject sut)
        {
            // -- arrange

            // -- act


            // -- assert
            Assert.NotNull(sut._dep);
            Assert.Equal(sut._dep, dep);
            Assert.Equal("someuniquestring", uniquestring);
        }


    }
}
