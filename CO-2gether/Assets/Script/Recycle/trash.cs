using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    public GameObject backGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tooth"))
            this.backGround.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
