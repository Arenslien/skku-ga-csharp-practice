using UnityEngine;

public class OperatorExample : MonoBehaviour
{
    void Start()
    {
        // 연산: 주어진 식을 계산해서 결과를 얻어내는 과정
        // 연산자: 연산을 수행하는 기호
        
        // 수학 연산자(산술 연산자: 사칙연산을 수행하는 연산자)
        // + - * / %
        int number1 = 20;
        int number2 = 30;
        Debug.Log(number1 + number2);
        Debug.Log(number1 - number2);
        Debug.Log(number1 * number2);
        Debug.Log(number1 / number2);
        Debug.Log(number1 % number2);
        Debug.Log(200 + 300); // 리터럴 데이터 
        
        // 대입 연산자
        string myFavoriteNovel = "무한의 마법사";
        
        // 증감 연산자: 값이 1씩 증가 or 감소할 때 사용하는 연산자
        int age = 27;
        age++; // 후위 증감 연산자 -> 우선순위의 차이
        ++age; // 전위 증감 연산자
        
        // 비교 연산자
        int age2 = 28;
        int age3 = 20;
        Debug.Log(age2 == age3);
        Debug.Log(age2 != age3);
        Debug.Log(age2 > age3);
        Debug.Log(age2 < age3);
        Debug.Log(age2 >= age3);
        Debug.Log(age2 <= age3);
        
        // 논리 연산자 = 비교 연산자가 동시에 두 개 이상 사용할 때 쓰는 연산자
        // 비교 연산의 결과는 : true/false
        
        // (AND) : && // T T --> T
        // (OR)  : || // T or F , F or T, T or T --> T
        // (NOT) : ! // T --> F // F --> T
        
        // 삼항 연산자: 조건식을 사용해서 조건식의 참/거짓에 따라 다른 값을 대입
        int health = 100;
        int damage = 50;
        
        // 변수 = 조건식 ? 참 일 때 대입할 값:거짓일 때 대입할 값
        bool isDie = health - damage > 0 ? false : true;
        Debug.Log(isDie);



    }
}