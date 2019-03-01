using System;
using CIService;
using Xunit;

namespace CiService.unittest
{
    public class GreeterServiceTests
    {
        [Fact]
        public void P_GetGreetText_WhenValidNameSent_ThenReturnsGreetText()
        {
            //Arrange
            var greeterService = new GreeterService();
            var expectedOutput = "Hello Micros!";
            //Act
            var greetText = greeterService.GetGreetText("Micros");

            //Assert
            Assert.True(greetText == expectedOutput);
        }
    }
}
