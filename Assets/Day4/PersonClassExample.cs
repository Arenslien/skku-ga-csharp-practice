using UnityEngine;

public class PersonClassExample : MonoBehaviour
{
    private void Start()
    {
        Person person1 = new Person("정성훈", 27, 156.5f, 58d, true);
        
        person1.Introduce(); // .은 멤버 접근 연산자
        person1.Run();
        
        Person person2 = new Person("정훈", 25, 170.0f, 78d, false);

        person2.Introduce();
        person2.Run();

        Chair chair1 = new Chair();
        chair1.Color = "파란색";
        
        person1.SeatDown(chair1);
        person2.SeatDown();

        person1.Punch(person2);

        Person person3 = null; // 메모리 주소를 가리킬 변수만 만들었지 알맹이는 존재하지 않음.
        // 존재하지 않는 값
        // 객체지향 프로그래밍에서 제임스 고슬링이 땅을 치고 후회하는 문법 중 하나
        // 가장 빈번하게 오류를 일으키는 문법

        person1.Punch(person3);
    }

    private void Update()
    {
        
    }
}
