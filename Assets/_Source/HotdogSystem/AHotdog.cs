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

        public virtual string GetName() => HotDogSo.Name;

        public virtual int GetWeight() => HotDogSo.Weight;

        public virtual int GetCost() => HotDogSo.Cost;
    }
}