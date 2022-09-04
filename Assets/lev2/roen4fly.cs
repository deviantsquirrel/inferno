using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roen4fly : MonoBehaviour
{
    public float targetTime = 0.0f;
    public static float forwardMovementSpeed = 3.0f;
    public static int sppedd = 8;
    private Rigidbody2D rb2d;
    float PosX;
    float PosY;
    // Start is called before the first frame update
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
        Vector2 vel;
        targetTime += Time.deltaTime;
        PosX = -3.0f + Mathf.Cos(targetTime * sppedd) * forwardMovementSpeed;
        PosY = 0 + Mathf.Sin(targetTime * sppedd) * forwardMovementSpeed;
        rb2d.transform.position = new Vector3(PosX, PosY, 0.0f);

    }
}
