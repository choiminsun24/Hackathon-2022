using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;

    float speed;

    public GameObject waterSize;
    public Vector3 objectScale;


    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        waterSize = GameObject.Find("WaterSize");
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {   
        if (hitObject.tag == "Plant")
        {
            objectScale = waterSize.transform.localScale;
            waterSize.transform.localScale = new Vector3(objectScale.x, objectScale.y + 0.1f, objectScale.z);
            Destroy(gameObject);
        }

        if (hitObject.tag == "RemoveBox")
        {
            Destroy(gameObject);
        }
    }
}
