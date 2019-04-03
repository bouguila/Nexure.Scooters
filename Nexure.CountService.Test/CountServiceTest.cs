using System;
using NexureCountService.Core;
using Xunit;

namespace Nexure.CountService.Test
{
    public class CountServiceTest
    {
        ICountService countService = new NexureCountService.Core.CountService();

        [Fact]
        public void Test1()
        {
            //Arrange
            int c = 9;
            int p = 5;
            int[] scooters = {11, 15, 13};

            //Act
            int res = countService.CountMinFE(scooters, c, p);

            //Assert
            Assert.Equal(7, res);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int c = 12;
            int p = 5;
            int[] scooters = {15, 10};

            //Act
            int res = countService.CountMinFE(scooters, c, p);

            //Assert
            Assert.Equal(3, res);
        }
    }
}
