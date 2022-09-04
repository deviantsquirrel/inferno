using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornFly : MonoBehaviour
{
    public static float forwardMovementSpeed = 10.0f;
    private Rigidbody2D rb2d;
    public float targetTime = 0.0f;
    // Start is called before the first frame update

    void GoEn()
    {
        rb2d.AddForce(new Vector2(16, 0));

    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoEn", 1);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel;
        targetTime += Time.deltaTime;
        if (targetTime < 1.9f)
        {
            vel.y = -3.0f;
            vel.x = 7.0f;
            //Debug.Log("Time is up");

            rb2d.velocity = vel;
            //targetTime = 0.0f;
        }
        if (rb2d.transform.position.y <= -3.57&& rb2d.transform.position.x >= - 7.5)
        {
            vel.y = 0.0f;
            vel.x = -7.0f;
            
            rb2d.velocity = vel;
        }
        if (rb2d.transform.position.x <= -7.5&& rb2d.transform.position.y <= 2.31)
        {
            vel.y = 7.0f;
            vel.x = 0.0f;
            rb2d.velocity = vel;
        }
        if (rb2d.transform.position.y >= 2.31)
        {
            targetTime = 0.0f;
        }

    }
}
