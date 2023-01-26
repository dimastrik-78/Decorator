namespace HotdogSystem
{
    public abstract class Hotdog
    {
        public Hotdog(HotDogSO hotDogSo)
        {
            // Name = name;
        }
        
        public abstract HotDogSO HotDogSo { get; }

        public abstract string GetName();
        
        public abstract int GetWeight();

        public abstract int GetCost();
    }
}