using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class DataSave
{
    public int Score;
}

public class DataManager : MonoBehaviour
{
    string path;

    void Start()
    {
        path = Path.Combine(Application.dataPath, "Score/score.json"); //경로 찾기
        JsonLoad();
    }

    public void JsonLoad()
    {
        DataSave data = new DataSave();

        if (!File.Exists(path)) //파일 없으면 만들기
        {
            Calculate.instance.Score = 0;
            JsonSave();
        }
        else
        {
            string loadJson = File.ReadAllText(path); //path에서 가져오기
            data = JsonUtility.FromJson<DataSave>(loadJson); //DataSave에 맞게 data로 가져온거지

            if (data != null) //값이 있으면 Calculate로 가져오기.
            {
                Calculate.instance.Score = data.Score;
            }
        }
    }

    public void JsonSave()
    {
        DataSave data = new DataSave();
        data.Score = Calculate.instance.Score;

        string json = JsonUtility.ToJson(data, true); //Calculate에서 가져온 정보를 json으로 바꿈

        File.WriteAllText(path, json); //적기
    }
}