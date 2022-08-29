using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tooth : MonoBehaviour
{
    public GameDirector gameDirector;
    public GameMain gameMain;

    Vector3 clickPoint;
    float Speed = 3.0f;

    void OnMouseDown()
    {
        clickPoint = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 diff = Input.mousePosition - clickPoint;
        Vector3 pos = transform.position;

        pos.x += diff.x * Time.deltaTime * Speed;
        transform.position = pos;
        clickPoint = Input.mousePosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
        this.gameMain = GameObject.Find("GameMain").GetComponent<GameMain>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GeneralTrash"))
            Destroy(this.gameObject);
        else if (collision.CompareTag("foodTrash")|| collision.CompareTag("plasticTrash")|| collision.CompareTag("paperTrash"))
        {
            this.gameDirector.damage();
            Destroy(this.gameObject);
        }
    }
}
