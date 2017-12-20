using System;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using ss.Testing.xUnit.AutoMoq;
using ss.Testing.xUnit.AutoNSubstitute.Example.Assets;
using Xunit;

namespace ss.Testing.xUnit.AutoNSubstitute.Example
{
    public class MoqTests
    {
        [Theory]
        [AutoMoqData]
        public void AutoMoqDataTest(
           string someString,
           [Frozen] Mock<ISutDepedency> dep,
           SutObject sut)
        {
            // -- arrange
            dep.Setup(d => d.GetSomething()).Returns(someString);

            // -- act
            var result = sut._dep.GetSomething();

            // -- assert
            Assert.Equal(someString, result);
        }


        [Theory]
        [InlineAutoMoqData("someuniquestring")]
        public void InlineAutoMoqDataTest(
            string uniquestring,
            [Frozen] Mock<ISutDepedency> dep,
            SutObject sut)
        {
            // -- arrange

            // -- act


            // -- assert
            Assert.NotNull(sut._dep);
            Assert.Equal(sut._dep, dep.Object);
            Assert.Equal("someuniquestring", uniquestring);
        }

        
    }
}
