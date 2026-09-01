using UnityEngine;

public class Person : Animal
{
    private int _age = 0;
    public bool HasGlasses = false;

    
    // 생성자 (메서드)
    // - 객체가 생성될 때 new 키워드와 함께 호출하는 메서드
    // - 클래스 이름과 같아야 한다.
    public Person(string name, int age, float height, double weight, bool hasGlasses) // 매개변수
    {
        _name = name;
        _age = age;
        HasGlasses = hasGlasses;
        _weight = weight;
        _height = height;
    }
    
    // 기능 (Method) : 함수 ...
    public override void Introduce()
    {
        Debug.Log($"안녕. 이름은 {_name}이고, 나이는 {_age}. 키와 몸무게는 {_height}cm / {_weight}kg. 잘 부탁.");
    }

    // 메서드 오버로드
    public void SeatDown()
    {
        Debug.Log($"{_name}이(가) 땅바닥에 앉았다.");
    }
    
    // 메서드 오버로드
    public void SeatDown(Chair chair)
    {
        Debug.Log($"{_name}이(가) {chair.Color} 의자를 앉았다.");
    }

    public void Punch(Person otherPerson)
    {
        string Name = "변수 쉐도잉 실시";
        
        // 하지만 this. 를 사용하면 변수 쉐도잉 방지하고 객체 자신의 속성에 접근
        // 그러나 this를 쓰면 안됨.
        // public 멤버 변수는 대문자로 시작하는 Pascal Case 사용
        // private 필드 변수는: _name (underbar + camel case)
        // 지역 변수는: name (camel case)
        Debug.Log($"{this._name}이(가) {otherPerson._name}(이)를 때렸다.");
    }
}