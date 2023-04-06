using HotdogSystem;
using HotdogSystem.HotdogDecoratorSystem;
using UnityEngine;

public class TestingCode : MonoBehaviour
{
    //сериализованное поле и инкапсулированная инициализация
    //неявные зависимости
    [SerializeField] private HotDogSO[] hotDogSo;

    void Start()
    {
        AHotdog hotdog1 = new HotdogClassic(hotDogSo[0]);
        AHotdog hotdog2 = new HotdogBig(hotDogSo[1]);
        AHotdog hotdog3 = new HotdogMean(hotDogSo[2]);
        
        AHotdog hotdog4 = new HotdogDecorator1(hotDogSo[3], hotdog1);
        AHotdog hotdog5 = new HotdogDecorator2(hotDogSo[4], hotdog1);
        Debug.Log($"{hotdog1.GetName()}({hotdog1.GetWeight()}г) - {hotdog1.GetCost()}руб \n {hotdog4.GetName()}({hotdog4.GetWeight()}г) - {hotdog4.GetCost()}руб \n {hotdog5.GetName()}({hotdog5.GetWeight()}г) - {hotdog5.GetCost()}руб");
        
        hotdog4 = new HotdogDecorator1(hotDogSo[3], hotdog2);
        hotdog5 = new HotdogDecorator2(hotDogSo[4], hotdog2);
        Debug.Log($"{hotdog2.GetName()}({hotdog2.GetWeight()}г) - {hotdog2.GetCost()}руб \n {hotdog4.GetName()}({hotdog4.GetWeight()}г) - {hotdog4.GetCost()}руб \n {hotdog5.GetName()}({hotdog5.GetWeight()}г) - {hotdog5.GetCost()}руб");

        hotdog4 = new HotdogDecorator1(hotDogSo[3], hotdog5);
        hotdog5 = new HotdogDecorator2(hotDogSo[4], hotdog5);
        Debug.Log($"{hotdog3.GetName()}({hotdog3.GetWeight()}г) - {hotdog3.GetCost()}руб \n {hotdog4.GetName()}({hotdog4.GetWeight()}г) - {hotdog4.GetCost()}руб \n {hotdog5.GetName()}({hotdog5.GetWeight()}г) - {hotdog5.GetCost()}руб");

    }
}
