using UnityEngine;

public class IfExample : MonoBehaviour
{
    void Start()
    {
        // 무조건 양수인 숫자가 짝수면 "짝수!" , 홀수면 "홀수!" , 0이면 "0!" 출력하는 코드
        uint number = 0;
        if (number == 0)
        {
            Debug.Log("0!");
        }
        else if (number % 2 == 0)
        {
            Debug.Log("짝수!");
        }
        else
        {
            Debug.Log("홀수!");
        }
        
        // 중첩 조건문 예시: 로그인 상황
        // 아이디를 입력하지 않을면 : "존재하지 않는 ID입니다."

        string userInputId = "admin";
        string userInputPassword = "1234";
        
        const string AdminId = "admin";
        const string AdminPassword = "4321";

        if (userInputId == AdminId)
        {
            if (userInputPassword == AdminPassword)
            {
                Debug.Log("로그인 성공!");
            }
            else
            {
                Debug.Log("비밀번호가 틀렸습니다.");
            }
        }
        else
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }
    }
}
