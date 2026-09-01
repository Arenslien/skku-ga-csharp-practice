using UnityEngine;

// 상속
public class Dog : Animal
{
    public Dog(string name, float height, double weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }

    public override void Introduce()
    {
        // Git Desktop 변화 감지 테스트
        Debug.Log($"멍멍~ 내 이름은 {_name}이다 멍~");
    }
}