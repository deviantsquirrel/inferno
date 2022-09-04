using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl2 : MonoBehaviour
{
    public float forwardMovementSpeed = 4.0f;
    //private Rigidbody2D rb2d;
    public float targetTime = 0.0f;
    public int forw = 1;
    
    void Update()
    {
        if (forw == 0)
        {
            transform.position = new Vector2(transform.position.x + forwardMovementSpeed * Time.deltaTime, transform.position.y);
            
            if (transform.position.x >= 1.81)
            {
                forw = 1;
            }
        }

        if (forw == 1)
        {
            
            transform.position = new Vector2(transform.position.x - forwardMovementSpeed * Time.deltaTime, transform.position.y );

            if (transform.position.x <= -5.69)
            {
                forw = 0;
            }
        }


    }
}
