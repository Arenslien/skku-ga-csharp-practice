using System.Runtime.CompilerServices;
using UnityEngine;

public class WhileExample : MonoBehaviour
{
    private void Start()
    {
        // while
        // for과 다르게 괄호 내부에 조건식만 들어간다.

        int i = 0;
        while (i < 1000)
        {
            Debug.Log("Hi");
            
            i++; // 증감식을 빼먹으면 반복문이 무한 루프에 빠져서 유니티가 멈춘다. 

            if (i > 1000)
            {
                break;
            }
        }
    }
}
