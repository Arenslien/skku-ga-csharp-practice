using UnityEngine;

public class StringParseExample : MonoBehaviour
{
    void Start()
    {
        string stringAge = "38살";
        int intAge = 10; 
        Debug.Log("초기값: " + intAge);
        
        bool result1 = int.TryParse(stringAge, out intAge);
        
        if (result1)
        {
            Debug.Log(intAge);
        }
        else
        {
            Debug.Log($"실패했을 때의 값: {intAge}");
            Debug.Log("Failed");
        }

        // float => 문자열
        float floatHeight = 174f;
        string stringHeight = floatHeight.ToString();
        Debug.Log(stringHeight);
        
        
        string stringWeight = "70.2kg";
        float floatWeight = 50.0f;
        Debug.Log("초기값: " + floatWeight);
        
        bool result2 = float.TryParse(stringWeight, out floatWeight);
        
        if (result2)
        {
            Debug.Log(floatWeight);
        }
        else
        {
            Debug.Log($"실패했을 때의 값: {floatWeight}");
            Debug.Log("Failed");
        }
    }
}
