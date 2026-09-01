using UnityEngine;

public class ForExample : MonoBehaviour
{
    private void Start()
    {
        // 초기식: 처음 한 번 실행할 식(보통 변수의 선언) : ex. int i = 0;
        // 조건식: 값을 비교해서 결과를 참/거짓인지 판명해주는 연산자
        // 증감연산자: ex. i++

        for (int i = 0; i < 1000; i++)
        {
            Debug.Log($"안녕하세요. {i:4D}");
        }

        int sum = 0;
        for (int i = 2; i <= 1000; i += 2)
        {
            sum += i;
        }

        Debug.Log($"1~1000 짝수의 합: {sum}");

        for (int i = 2; i < 10; i++)
        {
            if (i % 5 == 0)
            {
                continue;
            }
            
            Debug.Log($"구구단 {i}단 시작");
            for (int j = 1; j < 10; j++)
            {
                Debug.Log($"{i} x {j} = {i*j}");
            }
        }
}

    private void Update()
    {
        
    }
}
