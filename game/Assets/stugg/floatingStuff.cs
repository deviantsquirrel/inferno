using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingStuff : MonoBehaviour
{
    private float forwardMovementSpeed = 1.0f;
    private Rigidbody2D rb2d;
    int forw = 0;
    void GoEn()
    {
        rb2d.AddForce(new Vector2(5, 0));


    }
   
    void Start()
    {
        Random rnd = new Random();
        int rr = Random.Range(1, 3);
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoEn", 1);
        if (rr == 2)
        {
            forw = 1;
        }
        else
        {
            forw = 0;
        }
        
    }

    void Update()
    {
        Vector2 vel;
        vel.y = 0.0f;
        if (forw == 1) {
            Debug.Log("forw == 1");
            vel.x = -forwardMovementSpeed;
            
            if (rb2d.transform.position.x <= -7.0f)
            {
                forw = 0;
                Debug.Log("Cross");
            }
        }
        else
        {
            vel.x = forwardMovementSpeed;
            if (rb2d.transform.position.x >= 7.0f)
            {
                forw = 1;
                Debug.Log("Cross");
            }
        }
        rb2d.velocity = vel;
    }
}
