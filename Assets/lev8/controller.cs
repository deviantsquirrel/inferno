using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public GameObject Ic11;
    public GameObject Ic12;
    public GameObject Ic21;
    public GameObject Ic22;
    public GameObject Ic31;
    public GameObject Ic32;
    public GameObject Ic41;
    public GameObject Ic42;

    public GameObject back11;
    public GameObject back12;
    public GameObject back21;
    public GameObject back22;
    public GameObject back31;
    public GameObject back32;
    public GameObject back41;
    public GameObject back42;

    int[] right;
    float[] xx;
    float[] yy;
    float[] po;

    public static int cliced = 0;
    public static int opened = 0;
    public static int pairs = 0;

    public GameObject canvaEnd;

    IEnumerator St1()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("lev9");
    }
    // Start is called before the first frame update
    void Start()
    {
        //right = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
        pairs = 0;
        canvaEnd.SetActive(false);
        xx = new float[] { -6.81f, -2.74f, 5.24f, 1.29f };
        yy = new float[] { -5.71f, -1.76f, 2.27f, 6.26f };
        po = new float[] { 1f, 1f, 0f, 0f };
        //right = ShuffleArray(right);
        xx = ShuffleArray(xx);
        yy = ShuffleArray(yy);
        po = ShuffleArray(po);
        //Debug.Log(right);
        if (po[0] == 0)
        {
            Ic11.transform.position = new Vector3(xx[0], 1.37f, 1);

            Ic12.transform.position = new Vector3(yy[0], -2.59f, 1);
        }
        else
        {
            Ic11.transform.position = new Vector3(yy[0], -2.59f, 1);
            Ic12.transform.position = new Vector3(xx[0], 1.37f, 1);
        }
        if (po[1] == 0)
        {
            Ic21.transform.position = new Vector3(xx[1], 1.37f, 1);
            Ic22.transform.position = new Vector3(yy[1], -2.59f, 1);
        }
        else
        {
            Ic21.transform.position = new Vector3(yy[1], -2.59f, 1);
            Ic22.transform.position = new Vector3(xx[1], 1.37f, 1);
        }
        if (po[2] == 0)
        {
            Ic31.transform.position = new Vector3(xx[2], 1.37f, 1);
            Ic32.transform.position = new Vector3(yy[2], -2.59f, 1);
        }
        else
        {
            Ic31.transform.position = new Vector3(yy[2], -2.59f, 1);
            Ic32.transform.position = new Vector3(xx[2], 1.37f, 1);
        }
        if (po[3] == 0)
        {
            Ic41.transform.position = new Vector3(xx[3], 1.37f, 1);
            Ic42.transform.position = new Vector3(yy[3], -2.59f, 1);
        }
        else
        {
            Ic41.transform.position = new Vector3(yy[3], -2.59f, 1);
            Ic42.transform.position = new Vector3(xx[3], 1.37f, 1);
        }



    }


    private float[] ShuffleArray(float[] numbers)
    {
        float[] newArray = numbers.Clone() as float[];
        for (int i = 0; i < newArray.Length; i++)
        {
            float tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
    // Update is called once per frame
    void Update()
    {
        if (pairs == 4)
        {
            Debug.Log("Go");
            canvaEnd.SetActive(true);
            StartCoroutine(St1());
        }
    }
}
