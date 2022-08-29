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
        path = Path.Combine(Application.streamingAssetsPath + "/Json/score.json"); //��� ã��
        JsonLoad();
    }

    public void JsonLoad()
    {
        DataSave data = new DataSave();

        if (!File.Exists(path)) //���� ������ �����
        {

            Debug.Log("");
        }
        else
        {
            string loadJson = File.ReadAllText(path); //path���� ��������
            data = JsonUtility.FromJson<DataSave>(loadJson); //DataSave�� �°� data�� �����°���

            if (data != null) //���� ������ Calculate�� ��������.
            {
                Calculate.instance.Score = data.Score;
            }
        }
    }

    public void JsonSave()
    {
        DataSave data = new DataSave();
        data.Score = Calculate.instance.Score;

        string json = JsonUtility.ToJson(data, true); //Calculate���� ������ ������ json���� �ٲ�

        File.WriteAllText(path, json); //����
    }
}