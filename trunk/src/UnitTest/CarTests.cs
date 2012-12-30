namespace SoftwareSprint.UnitTest
{
    using NSubstitute;

    using NUnit.Framework;

    using SoftwareSprint.DemoLogic;
    using SoftwareSprint.Helper;

    [TestFixture]
    public class CarTests
    {
        private IWheel wheel = null;

        [SetUp]
        public void Setup()
        {
            this.wheel = Substitute.For<IWheel>();
            GenericClassFactory<IWheel, Wheel>.Dispenser = (args) => this.wheel;
        }

        // Stub test
        [Test]
        public void Drive_DoesNotThrowException_ReturnOk()
        {
            CarImproved carImproved = new CarImproved();
            carImproved.Drive();
        }

        // Mock test
        [Test]
        public void Drive_WheelIsTurned_ReturnOk()
        {
            CarImproved carImproved = new CarImproved();
            carImproved.Drive();

            this.wheel.Received().Turn();
        }

    }
}
