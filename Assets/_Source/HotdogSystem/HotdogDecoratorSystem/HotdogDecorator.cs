namespace HotdogSystem.HotdogDecoratorSystem
{
    // Конструктор
    // Жесткие зависимости
    public abstract class HotdogDecorator : AHotdog
    {
        private readonly AHotdog _hotdog;
        
        public HotdogDecorator(HotDogSO hotDogSo, AHotdog hotdog) : base(hotDogSo)
        {
            _hotdog = hotdog;
        }

        public override int GetWeight() => _hotdog.GetWeight() + HotDogSo.Weight;

        public override int GetCost() => _hotdog.GetCost() + HotDogSo.Cost;
    }
}