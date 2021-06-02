using System;
using AutoFixture;
using Newtonsoft.Json;
using RuRay.BLL.Models;
using RuRay.BLL.Tests.Helpers;
using RuRay.DAL.MySql.Models;
using Xunit;

namespace RuRay.BLL.Tests
{
    public class CarsServiceTests
    {
        [Theory]
        [InlineData("Mercedes", CarType.Hatchback)]
        [InlineData("BMW", CarType.Coupe)]
        [InlineData("Toyota", CarType.SUV)]
        public void CreateCar_Test(string modelName, CarType carType)
        {
            //Arrange
            var fixture = new Fixture();

            var car = Fixtures.CarFixture(modelName, carType);
            var mapper = Mapper.GetAutoMapper();
            var carsRepoMoq = Moqs.CarsReposirotyMoq(mapper.Map<CarEntity>(car));
            var carSvc = new CarsService(mapper, carsRepoMoq.Object);

            //Act
            var newCar = carSvc.CreateCarAsync(car).Result;

            //Assert
            var actual = JsonConvert.SerializeObject(car);
            var expected = JsonConvert.SerializeObject(newCar);
            Assert.Equal(expected.Trim(), actual.Trim());
        }

        [Fact]
        public void GetCar_Test()
        {
            //Arrange
            var fixture = new Fixture();

            var car = Fixtures.CarFixture();
            var mapper = Mapper.GetAutoMapper();
            var carsRepoMoq = Moqs.CarsReposirotyMoq(mapper.Map<CarEntity>(car));
            var carSvc = new CarsService(mapper, carsRepoMoq.Object);

            //Act
            var result = carSvc.GetCarAsync(fixture.Create<Guid>()).Result;

            //Assert
            var actual = JsonConvert.SerializeObject(car);
            var expected = JsonConvert.SerializeObject(result);
            Assert.Equal(expected.Trim(), actual.Trim());
        }
    }
}
