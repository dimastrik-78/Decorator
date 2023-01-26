namespace HotdogSystem.HotdogDecoratorSystem
{
    public class HotdogDecorator2 : HotdogDecorator
    {
        public HotdogDecorator2(HotDogSO hotDogSo, Hotdog hotdog) : base(hotDogSo, hotdog)
        {
            HotDogSo = hotDogSo;
            Hotdog = hotdog;
        }

        public override HotDogSO HotDogSo { get; }

        public override string GetName() => HotDogSo.Name;
        
        public override int GetWeight() => Hotdog.GetWeight() + HotDogSo.Weight;

        public override int GetCost() => Hotdog.GetCost() + HotDogSo.Cost;
    }
}