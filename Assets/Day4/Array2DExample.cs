using UnityEngine;

public class Array2DExample : MonoBehaviour
{
    private void Start()
    {
        // 2차원 배열
        // 2차원 배열은 게임 개발에서 주로 타일 기반에 사용된다.
        // 사용 예시:
        // 3match 퍼즐 게임, 맵, 인벤토리, 체스 등 표 형태의 데이터에 많이 사용
        
        int[] array1 = new int[] {1, 2, 3, 4, 5};
        int[,] enemyHealths = new int[2, 3];
        enemyHealths[0, 0] = 21;
        enemyHealths[0, 1] = 23;
        enemyHealths[0, 2] = 35;
        enemyHealths[1, 0] = 48;
        enemyHealths[1, 1] = 39;
        enemyHealths[1, 2] = 19;

        Debug.Log(enemyHealths[1, 1]);

        Debug.Log(enemyHealths.Length); // 6 (2 x 3) 출력

        int rowNumber = 2;
        int columnNumber = 3;
        // 배열은 항상 행 우선으로 접근을 해야 한다. 캐시 히트율을 위해서
        for (int row = 0; row < enemyHealths.Length / 3; row++)
        {
            for (int col = 0; col < enemyHealths.Length / 2; col++)
            {
                Debug.Log($"enemyHealths[{col}][{row}]: {enemyHealths[col, row]}");
            }
        }
        
            
        for (int col = 0; col < columnNumber; col++)
        {
            for (int row = 0; row < rowNumber; row++)
            {
                Debug.Log($"enemyHealths[{col}][{row}]: {enemyHealths[col, row]}");
            }
        }
        
    }
}
