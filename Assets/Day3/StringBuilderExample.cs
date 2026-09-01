using System;
using System.Text;
using UnityEngine;

public class StringBuilderExample : MonoBehaviour
{
    private void Start()
    {
        // 1. 문자열 추가
        StringBuilder sb = new StringBuilder("처음");
        sb.Append(", 그리고 마지막."); // 처음, 그리고 마지막.
        Debug.Log(sb);
				
        // 2, 문자열 삽입
        sb.Insert(8, "어쩌면 "); // 처음, 그리고 어쩌면 마지막.
        Debug.Log(sb);
				
        // 3. 문자열 삭제
        sb.Remove(4, 4); // 
        Debug.Log(sb);
				    
        // 4. 문자열 교체
        sb.Replace("처음", "8월");
        Debug.Log(sb);
    } 
}