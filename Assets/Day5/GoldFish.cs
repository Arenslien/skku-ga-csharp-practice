using System;
using UnityEngine;

public class GoldFish : Animal
{
    private string _color = String.Empty;
    public GoldFish(string name, string color)
    {
        _name = name;
        _height = 2;
        _weight = 0.3;
        _color = color;
    }

    public override void Introduce()
    {
        Debug.Log($"뻐끔 뻐끔~ 내 이름은 {_name}이다 뻐끔~ 내 비늘 색은 {_color}");
    }
}
