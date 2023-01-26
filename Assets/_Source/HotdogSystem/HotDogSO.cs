using UnityEngine;

namespace HotdogSystem
{
    [CreateAssetMenu(fileName = "HotDog", menuName = "Hotdog")]
    public class HotDogSO : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private int weight;
        [SerializeField] private int cost;
        
        public string Name => name;
        public int Weight => weight;
        public int Cost => cost;
    }
}