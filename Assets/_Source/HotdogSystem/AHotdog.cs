namespace HotdogSystem
{
    // Конструктор
    public abstract class AHotdog
    {
        public AHotdog(HotDogSO hotDogSo)
        {
            HotDogSo = hotDogSo;
        }

        public HotDogSO HotDogSo { get; }

        public string GetName() => HotDogSo.Name;

        public int GetWeight() => HotDogSo.Weight;

        public int GetCost() => HotDogSo.Cost;
    }
}