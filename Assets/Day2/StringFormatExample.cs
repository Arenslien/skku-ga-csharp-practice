using UnityEngine;

public class StringFormatExample : MonoBehaviour
{
    void Start()
    {
        string name = "정성훈";
        int age = 27;
        bool isMan = true;
        string gender = isMan ? "남자" : "여자";
        
        // "나의 이름은 OOO이고, 나이는 00살입니다. 성별은 00입니다."
        
        // 1. 문자열 연결 연산자 + 사용 방법
        Debug.Log("나의 이름은 " + name + "이고, 나이는 " + age + "살 입니다. 성별은 " + gender + "입니다.");
        
        // 2. 문자열 서식(String.Format)을 이용한 방식
        string introduceString = string.Format("나의 이름은 {0}이고, 나이는 {1}살입니다. 성별은 {2}입니다.", name, age, gender);
        Debug.Log(introduceString);
        
        // 3. $ 기호를 이용한 문자열 보간
        string introduceString2 = $"나의 이름은 {name}이고, 나이는 {age}살 입니다. 성별은 {gender}입니다.";
        Debug.Log(introduceString2);

        int money = 10000000;
        float height = 1234.567f;
        Debug.Log(height); // 1234.567  // 소수점 N 번째 자리까지만 출력할 때 -> 서식 문자열
        Debug.Log(money);  // 10000000  // 원 단위로 숫자 세자리마다, 를 붙여서 출력하고 싶다.
        Debug.Log(string.Format("{0:F1}", height));
        Debug.Log(string.Format("{0:N0}", money));

        Debug.Log($"{height:F1}");
        Debug.Log($"{money:N0}");

        int hour = 3;
        int minute = 13;
        // 03시 13분
        Debug.Log($"{hour:D2}시 {minute:D2}분");
    }
}
