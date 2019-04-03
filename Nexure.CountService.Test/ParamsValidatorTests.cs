using Nexure.CountService.Validators;
using System;
using Xunit;

namespace Nexure.CountService.Test
{
    public class ParamsValidatorTests
    {
        IParamsValidator validator = new ParamsValidator();

        [Fact]
        public void TestFEMinBoundaries()
        {
            //Arrange
            int c = 10;
            int p = -1;
            int[] scooters = {10, 55, 5};

            //Act
            try
            {
                validator.Validate(scooters, c, p);
                Assert.True(false, "");
            }

            //Assert
            catch (Exception e)
            {
                Assert.Equal("Incorrect number of Scooters For FE", e.Message);
            }
        }

        [Fact]
        public void TestFEMaxBoundaries()
        {
            //Arrange
            int c = 10;
            int p = 1001;
            int[] scooters = { 10, 55, 5 };

            //Act
            try
            {
                validator.Validate(scooters, c, p);
                Assert.True(false, "");
            }

            //Assert
            catch (Exception e)
            {
                Assert.Equal("Incorrect number of Scooters For FE", e.Message);
            }
        }

        [Fact]
        public void TestFMMinBoundaries()
        {
            //Arrange
            int c = -1;
            int p = 10;
            int[] scooters = { 10, 55, 5 };

            //Act
            try
            {
                validator.Validate(scooters, c, p);
                Assert.True(false, "");
            }

            //Assert
            catch (Exception e)
            {
                Assert.Equal("Incorrect number of Scooters For FM", e.Message);
            }
        }

        [Fact]
        public void TestFMMaxBoundaries()
        {
            //Arrange
            int c = 1000;
            int p = 10;
            int[] scooters = { 10, 55, 5 };

            //Act
            try
            {
                validator.Validate(scooters, c, p);
                Assert.True(false, "");
            }

            //Assert
            catch (Exception e)
            {
                Assert.Equal("Incorrect number of Scooters For FM", e.Message);
            }
        }

        [Fact]
        public void TestMinScootersPerDistrict()
        {
            //Arrange
            int c = 15;
            int p = 10;
            int[] scooters = { 10, 55, -1 };

            //Act
            try
            {
                validator.Validate(scooters, c, p);
                Assert.True(false, "");
            }

            //Assert
            catch (Exception e)
            {
                Assert.Equal("Incorrect number of Scooters in district", e.Message);
            }
        }

        [Fact]
        public void TestMaxScootersPerDistrict()
        {
            //Arrange
            int c = 5;
            int p = 10;
            int[] scooters = { 10, 1001, 5 };

            //Act
            try
            {
                validator.Validate(scooters, c, p);
                Assert.True(false, "");
            }

            //Assert
            catch (Exception e)
            {
                Assert.Equal("Incorrect number of Scooters in district", e.Message);
            }
        }
    }
}
