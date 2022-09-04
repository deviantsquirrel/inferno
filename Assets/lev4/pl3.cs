using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl3 : MonoBehaviour
{
    public float forwardMovementSpeed = 4.0f;
    //private Rigidbody2D rb2d;
    public float targetTime = 0.0f;
    public int forw = 0;

    void Update()
    {
        if (forw == 0)
        {
            transform.position = new Vector2(transform.position.x + forwardMovementSpeed * Time.deltaTime, transform.position.y);

            if (transform.position.x >= 3.0)
            {
                forw = 1;
            }
        }

        if (forw == 1)
        {

            transform.position = new Vector2(transform.position.x , transform.position.y - forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y <= -2.5)
            {
                forw = 2;
            }
        }
        if (forw == 2)
        {
            transform.position = new Vector2(transform.position.x - forwardMovementSpeed * Time.deltaTime, transform.position.y);

            if (transform.position.x <= -2.0)
            {
                forw = 3;
            }
        }

        if (forw == 3)
        {

            transform.position = new Vector2(transform.position.x , transform.position.y + forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y >= 1.45)
            {
                forw = 0;
            }
        }


    }
}
