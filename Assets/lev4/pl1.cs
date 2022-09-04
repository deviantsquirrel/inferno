using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl1 : MonoBehaviour
{
    public float forwardMovementSpeed = 4.0f;
    //private Rigidbody2D rb2d;
    public float targetTime = 0.0f;
    public int forw = 1;
    void GoEn()
    {
        //rb2d.AddForce(new Vector2(16, 0));

    }
    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
        //Invoke("GoEn", 1);

    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 vel;
        
        if (forw==0)
        {
            transform.position = new Vector2( transform.position.x, transform.position.y + forwardMovementSpeed * Time.deltaTime);
            //vel.y = 3.0f;
            //vel.x = 0.0f;

            //rb2d.velocity = vel;
            if(transform.position.y >= 3.5)
            {
                forw = 1;
            }
        }
        
        if ( forw == 1)
        {
            //vel.y = -3.0f;
            //vel.x = 0.0f;
            //rb2d.velocity = vel;
            transform.position = new Vector2(transform.position.x, transform.position.y - forwardMovementSpeed * Time.deltaTime);

            if (transform.position.y <= -4.0)
            {
                forw = 0;
            }
        }
        

    }
}
