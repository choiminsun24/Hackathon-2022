using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrow : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject water;
    private GameObject Object; 
    public Sprite[] plantType;

    void Update()
    {
        if (gameManager.clearCnt == 2) {
            Object.GetComponent<SpriteRenderer>().sprite = plantType[1];
        }
        else if (gameManager.clearCnt == 5) {
            Object.GetComponent<SpriteRenderer>().sprite = plantType[2];
        }
    }
}
