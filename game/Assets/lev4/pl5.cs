using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl5 : MonoBehaviour
{
    public float forwardMovementSpeed = 4.0f;
    //private Rigidbody2D rb2d;
    public float targetTime = 0.0f;
    public int forw = 0;

    void Update()
    {
        if (forw == 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y >= 2.55)
            {
                forw = 1;
            }
        }

        if (forw == 1)
        {

            transform.position = new Vector2(transform.position.x , transform.position.y - forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y <= -2.45)
            {
                forw = 0;
            }
        }



    }
}
