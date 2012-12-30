namespace SoftwareSprint.DemoLogic
{
    using SoftwareSprint.Helper;

    public class CarImproved
    {
        private readonly IWheel localWheel;

        public CarImproved()
        {
            GenericClassFactory<IWheel, Wheel> genericClassFactory = new GenericClassFactory<IWheel, Wheel>();
            this.localWheel = genericClassFactory.CreateInstance();
        }

        public void Drive()
        {
            this.localWheel.Turn();
        }
    }
}
