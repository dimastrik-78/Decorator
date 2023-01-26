namespace HotdogSystem
{
    public class HotdogMean : Hotdog
    {
        public HotdogMean(HotDogSO hotDogSo) : base(hotDogSo)
        {
            HotDogSo = hotDogSo;
        }
        
        public override HotDogSO HotDogSo { get; }

        public override string GetName() => HotDogSo.Name;

        public override int GetWeight() => HotDogSo.Weight;

        public override int GetCost() => HotDogSo.Cost;
    }
}