namespace HotdogSystem.HotdogDecoratorSystem
{
    // Конструктор
    // Жесткие зависимости
    public abstract class HotdogDecorator : AHotdog
    {
        protected AHotdog Hotdog;
        
        public HotdogDecorator(HotDogSO hotDogSo, AHotdog hotdog) : base(hotDogSo)
        {
            Hotdog = hotdog;
        }

        public new int GetWeight() => Hotdog.GetWeight() + HotDogSo.Weight;

        public new int GetCost() => Hotdog.GetCost() + HotDogSo.Cost;
    }
}