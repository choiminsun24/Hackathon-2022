using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Score;
    Calculate C;
    DataManager D;

    // Start is called before the first frame update
    void Start()
    {
        C = Score.GetComponent<Calculate>();
        D = Score.GetComponent<DataManager>();
        C.Score++;
        D.JsonSave();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
