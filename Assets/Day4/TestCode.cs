using UnityEngine;
using System.Text;

public class TestCode : MonoBehaviour
{
    private void Start()
    {
        string[,] miniMap = new string[4, 4];
				
        // 1. 맵 생성
        for (int row = 0; row < miniMap.GetLength(0); row++)
        {
            for (int col = 0; col < miniMap.GetLength(1); col++)
            {
                // miniMap 바깥쪽
                if (row == 0 || col == 0 || row == 3 || col == 3)
                {
                    miniMap[row, col] = "#"; // 벽
                }
                else if (row == col)
                {
                    miniMap[row, col] = "@"; // 아이템
                }
                else
                {
                    miniMap[row, col] = ".";
                }
            }
        }
				
        // 2. 플레이어 생성
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (miniMap[row, col] == ".")
                {
                    miniMap[row, col] = "P"; // 플레이어 생성
                }
            }
        }
				
        // 3. 맵 출력
        StringBuilder printedMap = new StringBuilder();
				
        for (int r = 0; r < 4; r++)
        {
            for (int c = 0; c < 4; c++)
            {
                printedMap.Append(miniMap[r, c]);
            }
            printedMap.Append('\n');
        }
        Debug.Log(printedMap.ToString());
    }
}