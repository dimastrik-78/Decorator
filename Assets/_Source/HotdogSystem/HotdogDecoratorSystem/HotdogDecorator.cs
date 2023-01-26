namespace HotdogSystem.HotdogDecoratorSystem
{
    public abstract class HotdogDecorator : Hotdog
    {
        protected Hotdog Hotdog;
        
        public HotdogDecorator(HotDogSO hotDogSo, Hotdog hotdog) : base(hotDogSo)
        {
            // Hotdog = hotdog;
        }
    }
}