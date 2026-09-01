using UnityEngine;

public class Cat : Animal
{
    public Cat(string name, float height, double weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }

    public override void Introduce()
    {
        Debug.Log($"냐옹~ 내 이름은 {_name}이다 냥~");
    }
}