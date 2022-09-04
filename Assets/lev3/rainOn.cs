using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainOn : MonoBehaviour
{
    private int state;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;

    public GameObject RainD1;
    public GameObject RainD2;
    public GameObject RainD3;
    public GameObject RainD4;

    public GameObject RainU1;
    public GameObject RainU2;
    public GameObject RainU3;
    public GameObject RainU4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("OutputTime", 0.1f, 5f);
        state = 1;
    }
    void letlight(GameObject lh)
    {
        lh.SetActive(true);
    }

    void letrain(GameObject lh, GameObject gf)
    {
        lh.SetActive(true);
        gf.SetActive(true);
    }

    void Dry()
    {
        RainD1.SetActive(false);
        RainD2.SetActive(false);
        RainD3.SetActive(false);
        RainD4.SetActive(false);
        RainU1.SetActive(false);
        RainU2.SetActive(false);
        RainU3.SetActive(false);
        RainU4.SetActive(false);
    }

    IEnumerator St1()
    {
        Debug.Log("here");
        letlight(light1);
        yield return new WaitForSeconds(1f);
            Dry();
            letrain(RainD1, RainU1);
            yield return new WaitForSeconds(4f);
            light1.SetActive(false);
    }

    IEnumerator St2()
    {
        letlight(light2);
        yield return new WaitForSeconds(1f);
        Dry();
        letrain(RainD2, RainU2);
        yield return new WaitForSeconds(4f);
        light2.SetActive(false);
    }

    IEnumerator St3()
    {
        letlight(light3);
        yield return new WaitForSeconds(1f);
        Dry();
        letrain(RainD3, RainU3);
        yield return new WaitForSeconds(4f);
        light3.SetActive(false);
    }

    IEnumerator St4()
    {
        letlight(light4);
        yield return new WaitForSeconds(1f);
        Dry();
        letrain(RainD4, RainU4);
        yield return new WaitForSeconds(4f);
        light4.SetActive(false);
    }
    // Update is called once per frame

    void OutputTime()
    {
        Random rnd = new Random();
        int rr = state;
        rr = Random.Range(1, 5);
        while (rr==state)
        {
            rr = Random.Range(1, 3);
        }
        state = rr;
        //state = Random.Range(1, 3);
        Debug.Log(state);
        if (state==1)
        {
            StartCoroutine(St1());
            //St1();

        }
        else if (state == 2)
        {
            StartCoroutine(St2());
            //St2();
        }
        else if (state == 3)
        {
            StartCoroutine(St3());
            //St2();
        }
        else if (state >= 4)
        {
            StartCoroutine(St4());
            //St2();
        }
    }
    void Update()
    {
        
        //light1.SetActive(true);
        //RainD1.SetActive(true);
        //RainU1.SetActive(true);
        
    }
}
