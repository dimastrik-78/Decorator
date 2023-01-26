namespace HotdogSystem
{
    public class HotdogBig : Hotdog
    {
        public HotdogBig(HotDogSO hotDogSo) : base(hotDogSo)
        {
            HotDogSo = hotDogSo;
        }
        
        public override HotDogSO HotDogSo { get; }

        public override string GetName() => HotDogSo.Name;

        public override int GetWeight() => HotDogSo.Weight;

        public override int GetCost() => HotDogSo.Cost;
    }
}