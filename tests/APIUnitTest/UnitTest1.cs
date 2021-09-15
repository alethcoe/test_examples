using NUnit.Framework;

namespace APIUnitTest
{
    public class Tests
    {
        CarAPI.Car car = null;
        [SetUp]
        public void Setup()
        {
            var sut = new CarAPI.Controllers.CarsController(null);
            car = sut.GetCar();
        }

        [Test]
        public void GetCarReturnsCar()
        {
            var sut = new CarAPI.Controllers.CarsController(null);
            var car = sut.GetCar();
            Assert.IsNotEmpty(car.Condition);
            Assert.IsNotEmpty(car.Make);

            bool canConvertToNumber = int.TryParse(car.Year, out _);
            Assert.IsTrue(canConvertToNumber);
        }


        [Test]
        public void CarConditionHasValue()
        {
            Assert.IsNotEmpty(car.Condition);
        }

        [Test]
        public void CarMakeHasValue()
        {
            Assert.IsNotEmpty(car.Make);
        }


        [Test]
        public void CarYearIsNumber()
        {
            bool canConvertToNumber = int.TryParse(car.Year, out _);
            Assert.IsTrue(canConvertToNumber);
        }
    }
}