namespace SoftwareSprint.DemoLogic
{
    public class Car
    {
        private readonly IWheel localWheel = null;

        public Car(IWheel wheel)
        {
            this.localWheel = wheel;
        }

        public IWheel LocalWheel
        {
            get { return this.localWheel; }
        }

        public void Drive()
        {
            this.localWheel.Turn();
        }
    }
}
