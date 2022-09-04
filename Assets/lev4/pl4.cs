using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl4 : MonoBehaviour
{
    public float forwardMovementSpeed = 4.0f;
    //private Rigidbody2D rb2d;
    public float targetTime = 0.0f;
    public int forw = 0;

    void Update()
    {
        if (forw == 0)
        {
            transform.position = new Vector2(transform.position.x - forwardMovementSpeed * Time.deltaTime, transform.position.y);

            if (transform.position.x <= -3.25)
            {
                forw = 1;
            }
        }

        if (forw == 1)
        {

            transform.position = new Vector2(transform.position.x + forwardMovementSpeed * Time.deltaTime, transform.position.y );

            if (transform.position.x >= 6.0)
            {
                forw = 3;
            }
        }

        if (forw == 3)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y >= 2.55)
            {
                forw = 4;
            }
        }

        if (forw == 4)
        {

            transform.position = new Vector2(transform.position.x, transform.position.y - forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y <= -3.68)
            {
                forw = 0;
            }
        }

    }
}
