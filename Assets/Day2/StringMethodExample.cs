using UnityEngine;

public class StringMethodExample : MonoBehaviour
{
    void Start()
    {
        // // 길이 속성
        // string name = "   누런양동이 새상을 놀라게 하다.   ";
        // Debug.Log($"이름 길이 : {name.Length}");
        //
        // // 문자열은 불변식이므로 문자가 수정될때마다 새로 메모리를 할항한다.
        // // 그러므로 잘 해라..
        //
        // // 탐색 기능 : 문자열 안에서 특정 문자열의 존재 유무, 있다면 인덱스 반환
        // int index = name.IndexOf("크");
        // Debug.Log(index);
        // bool isHwang = name.StartsWith("누");
        // Debug.Log(isHwang);
        // bool isContainEagle = name.Contains("양동이");
        // Debug.Log(isContainEagle);
        //
        // // 변형 기능 : 대소문자 변환, 추가, 대체, 삭제 등
        // name = name.Trim();
        //
        // name = name.Insert(6, "온");
        // Debug.Log(name);
        //
        // name = name.Remove(17);
        // Debug.Log(name);
        //
        // name = name.Replace("새", "세");
        // Debug.Log(name);
        //
        // string name2 = "Steve";
        // name2 = name2.ToUpper();
        // Debug.Log(name2);
        // name2 = name2.ToLower();
        // Debug.Log(name2);
        
        
        string name = "prefix누런양동이 새상을 놀라게 하다.suffix";
		    
        // 1. 길이 속성 (Property)
        Debug.Log($"길이: {name.Length}"); // 공백 포함 29 출력

        // 2. 탐색 기능 (Search)
        Debug.Log($"양동이 포함 유무: {name.Contains("양동이")}");
        Debug.Log($"누런 인덱스 위치: {name.IndexOf("누런")}");
        Debug.Log($"접두사 포함 유무: {name.StartsWith("prefix")}");
        Debug.Log($"접미사 포함 유무: {name.EndsWith("suffixx")}");
        
        // 3. 변형 기능 (Modification)
        name = name.ToUpper(); // 대문자 변환
        Debug.Log($"대문자 변환 이후: {name}");
        
        name = name.ToLower(); // 소문자 변환
        Debug.Log($"소문자 변환 이후: {name}");
        
        name = name.Replace("prefix", "   ");
        name = name.Replace("suffix", "      ");
        Debug.Log($"문자 대체 이후: {name}");
        
        Debug.Log($"양동이 이후 삭제 시: {name.Remove(name.IndexOf("양동이"))}");
        Debug.Log($"기존 name: {name}"); // Remove 결과값을 저장하지 않았기에 그대로
        
        name = name.Trim();
        Debug.Log($"Trim() 이후: {name}");
        
        name = name.Insert(6, "온");
        Debug.Log($"Insert() 이후: {name}");
        
        // 4. 분해 및 결합 기능 (Split & Join)
        string myFavoriteGame = "Minecraft, MapleStory, WorldOfWarCraft";
        string[] gameList = myFavoriteGame.Split(',');
        // ["Minecraft", "MapleStory", "WorldOfWarCraft"] 
        
        Debug.Log($"좋아하는 게임 : {gameList[1].Substring(0, 6)}");
        
        Debug.Log($"좋아하는 게임 3가지 : {string.Join(" & ", gameList)}");
        // "Minecraft & MapleStory & WorldOfWarCraft"
    }
}
