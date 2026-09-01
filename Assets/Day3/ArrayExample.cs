using System;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    private void Start()
    {
        // 배열: 같은 자료형의 데이터를 한 그룹으로 묶어서 사용하는 것
        // --> 연관된 데이터들을 모아서 관리하기 위해 사용
        
        // 배열(변수) 선언
        // 자료형[] 배열명 = new 자료형[크기(개수)]
        int[] monsterHealths = new int[5]; // 복수 명사로 뒤에 s 꼭 붙이기
        // --> int 자료형을 50개를 담을 수 있는 연속된 메모리 공간이 할당된다. (4 byte * 50)
        // 데이터 공간 하나하나를 보통 "Item"이라고 부른다.
        // 그리고 이 아이템에 접근할 수 있는 랜덤 엑세스를 제공하는데 이 순서를 "인덱스"
        
        monsterHealths[0] = 31;
        monsterHealths[1] = 42;
        monsterHealths[2] = 57;
        monsterHealths[3] = 28;
        monsterHealths[4] = 14;
        
        // 배열의 장점: 데이터가 연속적으로 들어가 있기 때문에 반복문을 이용해

        for (int i = 0; i < monsterHealths.Length; i++) // Length = 5;
        {
            Debug.Log($"몬스터 {i+1}의 현재 체력은: {monsterHealths[i]}");
        }
        
        // 자료형 생략
        int[] testArray = new int[] { 1, 2, 3, 4, 5 };
        int[] ages = new int[5] { 26, 17, 48, 59, 210 };
        
        Array.Sort(ages);
        Array.Reverse(ages);
        foreach (int age in ages)
        {
            Debug.Log(age);
        }
    }
}
