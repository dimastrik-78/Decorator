using System.Collections;
using System.Collections.Generic;
using HotdogSystem;
using HotdogSystem.HotdogDecoratorSystem;
using UnityEngine;

public class TestingCode : MonoBehaviour
{
    [SerializeField] private HotDogSO[] hotDogSo;
    void Start()
    {
        // Hotdog hotdog1 = new HotdogClassic("Обычынй", 5);
        // Hotdog hotdog2 = new HotdogBig("Большой", 13);
        // Hotdog hotdog3 = new HotdogMean("Маленький", 25);
        // Hotdog hotdog4 = new HotdogDecorator1("С сыр", 7, hotdog1);
        // Hotdog hotdog5 = new HotdogDecorator2("С капуста", 9, hotdog1);
        //
        // Debug.Log($"{hotdog1.GetName()} - {hotdog1.Cost} \n {hotdog4.Name} - {hotdog4.Cost} \n {hotdog5.Name} - {hotdog5.Cost}");
        //
        // hotdog4 = new HotdogDecorator1("С сыр", 7, hotdog2);
        // hotdog5 = new HotdogDecorator2("С капуста", 9, hotdog2);
        // Debug.Log($"{hotdog2.GetName()} - {hotdog2.Cost} \n {hotdog4.Name} - {hotdog4.Cost} \n {hotdog5.Name} - {hotdog5.Cost}");
        //
        //
        // hotdog4 = new HotdogDecorator1("С сыр", 7, hotdog3);
        // hotdog5 = new HotdogDecorator2("С капуста", 9, hotdog3);
        // Debug.Log($"{hotdog3.GetName()} - {hotdog3.Cost} \n {hotdog4.Name} - {hotdog4.Cost} \n {hotdog5.Name} - {hotdog5.Cost}");

        Hotdog hotdog1 = new HotdogClassic(hotDogSo[0]);
        Hotdog hotdog2 = new HotdogBig(hotDogSo[1]);
        Hotdog hotdog3 = new HotdogMean(hotDogSo[2]);
        
        Hotdog hotdog4 = new HotdogDecorator1(hotDogSo[3], hotdog1);
        Hotdog hotdog5 = new HotdogDecorator2(hotDogSo[4], hotdog1);
        Debug.Log($"{hotdog1.GetName()}({hotdog1.GetWeight()}г) - {hotdog1.GetCost()}руб \n {hotdog4.GetName()}({hotdog4.GetWeight()}г) - {hotdog4.GetCost()}руб \n {hotdog5.GetName()}({hotdog5.GetWeight()}г) - {hotdog5.GetCost()}руб");
        
        hotdog4 = new HotdogDecorator1(hotDogSo[3], hotdog2);
        hotdog5 = new HotdogDecorator2(hotDogSo[4], hotdog2);
        Debug.Log($"{hotdog2.GetName()}({hotdog2.GetWeight()}г) - {hotdog2.GetCost()}руб \n {hotdog4.GetName()}({hotdog4.GetWeight()}г) - {hotdog4.GetCost()}руб \n {hotdog5.GetName()}({hotdog5.GetWeight()}г) - {hotdog5.GetCost()}руб");

        hotdog4 = new HotdogDecorator1(hotDogSo[3], hotdog5);
        hotdog5 = new HotdogDecorator2(hotDogSo[4], hotdog5);
        Debug.Log($"{hotdog3.GetName()}({hotdog3.GetWeight()}г) - {hotdog3.GetCost()}руб \n {hotdog4.GetName()}({hotdog4.GetWeight()}г) - {hotdog4.GetCost()}руб \n {hotdog5.GetName()}({hotdog5.GetWeight()}г) - {hotdog5.GetCost()}руб");

    }
}
