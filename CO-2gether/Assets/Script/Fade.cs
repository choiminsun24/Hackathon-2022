using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public GameObject fadeimage;

    private Image image;

    Color color;

    private void Awake()
    {
        image = fadeimage.GetComponent<Image>();
        color = image.color;

        fadeimage.SetActive(true); //�� ���� �������ϸ� ����� image Ȱ��ȭ��Ű�� �� ���� ��
    }

    void Start()
    {
        StartCoroutine(Fadein());
    }

    // Update is called once per frame
    void Update()
    {

    }

    //���� true�� ����.
    IEnumerator Fadein() //ȭ���� ������ ��. 
    {
        while (color.a > 0)
        {
            color.a -= Time.deltaTime;
            image.color = color;

            yield return null;
        }

        fadeimage.SetActive(false);
    }

    IEnumerator Fadeout(string Name) //�� �̵�
    {
        while (color.a < 1)
        {
            color.a += Time.deltaTime;
            image.color = color;

            yield return null;
        }

        if (color.a >= 1)
        {
            SceneManager.LoadScene(Name);
            yield break;
        }
    }

    public void Move_Scene(string Name)
    {
        fadeimage.SetActive(true);
        StartCoroutine(Fadeout(Name));
    }
}