using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    private void Start()
    {
        Animal person1 = new Person("손정휘", 26, 179f, 50d, false);
        Animal cat1 = new Cat("삥삥", 30f, 10d);

        Animal person2 = new Person("황유찬", 21, 179, 45, false);
        Animal dog1 = new Dog("누리", 50, 15);

        Animal person3 = new Person("하지호", 28, 170f, 40, true);
        Animal dog2 = new Dog("덕자", 50, 10);

        Animal person4 = new Person("민범기", 26, 178, 64, false);
        Animal goldFish1 = new GoldFish("금이", "빨간색");
        Animal goldFish2 = new GoldFish("붕이","주황색");
        
        // 자료형[] 변수명 = new 자료형[크기] { 초기값 }
        // 클래스도 자료형이고 참조 타입이며 사용자 정의 자료형이라고 하기도 한다.
        Animal[] animals = new Animal[] { person1, cat1, person2, dog1, person3, dog2, person4, goldFish1, goldFish2 };

        // 동물들을 반복문을 이용해 순회하면서 Introduce 호출 가능
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].Introduce();
            
            // 동물이 사람 타입일 경우 자기소개 후 땅바닥에 앉는다.
            if (animals[i] is Person) // is: 객체가 실제로 해당 타입인지 검사 후 bool
            {
                // 1. 명시적 형변환
                Person person = (Person)animals[i];
                person.SeatDown();
            }
            
            // 2. as 형변환: 형변환 시도 후 성공은 성공 실패는 null
            Person pperson = animals[i] as Person;
            if (pperson != null)
            {
                pperson.SeatDown();
            }
        }
    }
}
