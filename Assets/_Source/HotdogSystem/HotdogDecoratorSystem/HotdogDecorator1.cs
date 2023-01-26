namespace HotdogSystem.HotdogDecoratorSystem
{
    public class HotdogDecorator1 : HotdogDecorator
    {
        public HotdogDecorator1(HotDogSO hotDogSo, Hotdog hotdog) : base(hotDogSo, hotdog)
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