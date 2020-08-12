using System;
using Microsoft.Extensions.Logging;
using Moq;
using Tests.SDET.BusinessLogic;
using Xunit;

namespace Tests.SDET.Tests
{
    public class OurProcessorShould
    {
        [Fact]
        public void ReturnAHashedStringGivenAValidInputString()
        {
            // arrange
            var loggerMock = new Mock<ILogger<OurProcessor>>();
            var sut = new OurProcessor(loggerMock.Object);

            // act
            var response = sut.GetHash("ThisNeedsScrambling123!");

            // assert
            Assert.Equal("eb6dadbf06b64cfde0b4a412bcccbfa35e4dbe665e6200361558ca433186de23", response);
        }

        [Fact]
        public void ThrowAnErrorIfPasswordInPassword()
        {
            // arrange
            var loggerMock = new Mock<ILogger<OurProcessor>>();
            var sut = new OurProcessor(loggerMock.Object);

            // act
            // assert
            Assert.Throws<Exception>(() => sut.GetHash("ThisStringContainsPasswordInIt!"));
        }
    }
}
