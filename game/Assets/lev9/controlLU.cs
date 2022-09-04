using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlLU : MonoBehaviour
{
    public static int Lstate = 2;
    public static int LLives = 20;
    public static int girlgo = 0;

    float last = 0f;
    float next = 5f;
    float pll = 3f;

    float targetTime = 1.0f;

    public GameObject luHor;

    public GameObject luVert;

    public GameObject plata;
    public GameObject stala;
    float[] xx;
    float[] yy;
    float nx = 0f;
    float ny = 0f;

    float nx1 = 0f;
    float ny1 = 0f;

    float nx2 = 0f;
    float ny2 = 0f;
    int go = 0;
    // Start is called before the first frame update
    void Start()
    {
        xx = new float[] { -6.81f, -2.74f, 5.24f, 1.29f, -3.81f, -1.74f, 2.24f, 3.29f };
        yy = new float[] { -2.71f, -1.76f, 2.27f, 3.26f, -0.71f, -0.76f, 1.9f, -3.26f };
        
    }

    // Update is called once per frame
    void Update()
    {
        xx = ShuffleArray(xx);
        yy = ShuffleArray(yy);
        
        

        if (targetTime > last)
        {
            luHor.SetActive(false);
            //secLuci.Aliv = 0;
            //GameObject bul = Instantiate(luVert);
            luVert.SetActive(true);
            // bul.SetActive(true);
            last += 10.0f;
        }
        
        if (targetTime > next)
        {
            luVert.SetActive(false);
            luHor.SetActive(true);
            // bul.SetActive(true);
            next += 10.0f;
        }

        if (targetTime > pll)
        {
            go = 1;
            pll += 4.0f;
        }

        if (go == 1)
        {
            StartCoroutine(St1());
            go = 0;
        }

        if (LLives<1)
        {
            luVert.SetActive(false);
            luHor.SetActive(false);
            girlgo = 1;


        }
        else
        {
            Debug.Log(LLives);
            targetTime += Time.deltaTime;
        }
    }

    IEnumerator St1()
    {
        Debug.Log("here");
        GameObject bul = Instantiate(plata);
        GameObject bul1 = Instantiate(plata);
        GameObject bul2 = Instantiate(plata);

        nx = xx[0];
        ny = yy[0];
        nx1 = xx[1];
        ny1 = yy[1];
        nx2 = xx[2];
        ny2 = yy[2];
        bul.transform.position = new Vector3(nx, ny-0.5f, 1);
        bul.SetActive(true);
        yield return new WaitForSeconds(1f);
        bul1.transform.position = new Vector3(nx1, ny1 - 0.5f, 1);
        bul1.SetActive(true);
        yield return new WaitForSeconds(1f);
        bul2.transform.position = new Vector3(nx2, ny2 - 0.5f, 1);
        bul2.SetActive(true);

        GameObject bula = Instantiate(stala);
        GameObject bula1 = Instantiate(stala);
        GameObject bula2 = Instantiate(stala);
        bula.SetActive(true);
        bula.transform.position = new Vector3(nx, ny, 1);
        yield return new WaitForSeconds(1f);

        bula1.SetActive(true);
        bula1.transform.position = new Vector3(nx1, ny1, 1);
        yield return new WaitForSeconds(1f);

        bula2.SetActive(true);
        bula2.transform.position = new Vector3(nx2, ny2, 1);
        yield return new WaitForSeconds(1f);

        bul.SetActive(false);
        bula.SetActive(false);
        bul1.SetActive(false);
        bula1.SetActive(false);
        bul2.SetActive(false);
        bula2.SetActive(false);


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

}