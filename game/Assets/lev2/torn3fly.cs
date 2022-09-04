using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static Unity.Mathematics.math;

public class torn3fly : MonoBehaviour
{
    //using.Unity.Mathematics;
    public float targetTime = 0.0f;
    private Rigidbody2D rb2d;
    float PosX;
    float PosY;
    void GoEn()
    {
        rb2d.AddForce(new Vector2(16, 0));
    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //rb2d.transform.position = new Vector3(2.5f, 3.0f, 0.0f);
        Invoke("GoEn", 1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time is up");
        Debug.Log(targetTime);
        Vector2 vel;
        targetTime += Time.deltaTime;
        PosX = 2.5f + Mathf.Cos(targetTime*5) * 3.0f;
        PosY = 0 + Mathf.Sin(targetTime*5) * 3.0f;
        rb2d.transform.position = new Vector3(PosX, PosY, 0.0f);

    }
}
