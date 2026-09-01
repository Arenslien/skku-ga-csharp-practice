using UnityEngine;
using UnityEngine.InputSystem;

enum Week
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday = 5,
    Friday,
    Saturday,
    Sunday
}

public class SwitchCaseExample : MonoBehaviour
{
    void Start()
    {
        int number = 4;
        switch (number)
        {
            case 1:
            {
                break;
            }
            case 2:
            {
                break;
            }
            case 3:
            {
                break;
            }
            default: // (옵션, 아무런 case에 해당 되지 않은 경우)
            {
                // code
                break;
            }
        }
        
        // 목표 : 변수 선언 및 요일에 따라 "오늘 O요일입니다!" 출력하는 코드 작성
        Week today = Week.Friday;

        switch(today)
        {
            case Week.Monday:
            {
                Debug.Log("오늘 월요일입니다!");
                break;
            }
            case Week.Tuesday:
            {
                Debug.Log("오늘 화요일입니다!");
                break;
            }
            case Week.Wednesday:
            {
                Debug.Log("오늘 수요일입니다!");
                break;
            }
            case Week.Thursday:
            {
                Debug.Log("오늘 목요일입니다!");
                break;
            }
            case Week.Friday:
            {
                Debug.Log("오늘 금요일입니다!");
                break;
            }
            case Week.Saturday:
            {
                Debug.Log("오늘 토요일입니다!");
                break;
            }
            default:
            {
                Debug.Log("요일이 없습니다.");
                break;
            }
        }
        
        // 변수 score 선언 , 점수에 따라 학점 부여
        int score = 76;
        
        switch (score / 10)
        {
            case 100:
            {
                Debug.Log("A+");
                break;
            }
            case 9:
            {
                Debug.Log("A");
                break;
            }
            case 8:
            {
                Debug.Log("B");
                break;
            }
            case 7:
            {
                Debug.Log("C");
                break;
            }
            case 6:
            {
                Debug.Log("D");
                break;
            }
            default:
            {
                Debug.Log("F");
                break;
            }
        }
    }

}
