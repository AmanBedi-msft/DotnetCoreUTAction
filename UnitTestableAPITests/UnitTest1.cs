using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Linq;
using UnitTestableAPI.Controllers;
using Xunit;

namespace UnitTestableAPITests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            WeatherForecastController home = new WeatherForecastController(logger.Object);
            var result = home.Get();
            Assert.Equal(5, result.ToList().Count);
        }
    }
}
