using UnityEngine;

public class DataTypeExample : MonoBehaviour
{
    void Start()
    {
        // 1. 정수형
        // int wealth = 12000000000; 오류
        // int의 범위는 약 -21억 ~ 21억
        // long 약 -900경 ~ 900경
        long wealth2 = 120000000000;
        short wealth3 = 32767;
        
        
        // 2. 실수(float, double, decimal)
        // float는 소수점 6자리, double은 14자리, decimal은 28자리
        float floaterNumber = 3.141592653589793238462643383279502884197169399f;
        double doubleNumber = 3.141592653589793238462643383279502884197169399d;
        decimal decimalNumber = 3.141592653589793238462643383279502884197169399m;

        Debug.Log(floaterNumber);
        Debug.Log(doubleNumber);
        Debug.Log(decimalNumber);
        
        // 3. 문자(열)
        char firstName = '정';
        string lastName = "성훈";
        
        // 4. 논리
        bool isDie = true; // is, has 3인칭 동사원형 단수형
        // supports
        
        // # 형변환
        // 큰 자료형에서 작은 자료형으로 가는 것을 주의

        long money1 = 928347928374982347;
        int money2 = (int)money1; // 명시적 형 변환

        Debug.Log(money1);
        Debug.Log(money2); // 강제 형변환하여 상위 32bit 제거 + 하위 32bit 중 가장 왼쪽 첫 번째 bit(MSB)가 1이 되면 컴퓨터가 이를 음수로 해석(2의 보수 표현 방식)

        int maxHealth1 = 88888;
        long maxHealth2 = 34;
        maxHealth2 = maxHealth1; // 작은 범위 -> 큰 범위는 자동 형변환 : 암시적 형 변환

        // # 상수: 데이터를 초기화 할 때 말고는 절대 변경할 수 없는 변수
        const int MaxHealth = 400; // const 키워드 필요 & 첫 글자 대문자
        // MaxHealth = 200; 불변 -> 변경되지 말아야 할 변수

        const int GameWidth = 10;
        const int GameHeight = 50;
        // const 의미: 절대 변경 불가능, 중요한 설정 값인가 보다
        
    } 
}