using UnityEngine;

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday = 5,
    Friday,
    Saturday,
    Sunday
}

enum Season
{
    Spring = 7, // 7
    Summer,     // 8
    Fall = 6,   // 6
    Winter      // 7
}

enum KeyBoardCode
{
    W,
    A,
    S,
    D
}

public class EnumExample : MonoBehaviour
{
    void Start()
    {
        DayOfWeek today = DayOfWeek.Thursday;

        if (today == DayOfWeek.Thursday)
        {
            Debug.Log("오늘은 목요일입니다.");
        }
        
        Debug.Log(today);
        Debug.Log((int)today);
        Debug.Log((int)DayOfWeek.Saturday); // 2 출력
        Debug.Log((int)DayOfWeek.Sunday);   // 3 출력
        
        Season todaySeason = Season.Summer;

        if (todaySeason == Season.Summer)
        {
            Debug.Log("여름입니다.");
        }

        KeyBoardCode currentInputKey = KeyBoardCode.A;

        if (currentInputKey == KeyBoardCode.A)
        {
            Debug.Log("왼쪽으로 이동");
        }

        Debug.Log((int)Season.Spring);
        Debug.Log((int)Season.Summer);
        Debug.Log((int)Season.Fall);
        Debug.Log((int)Season.Winter);
        
    }
}
