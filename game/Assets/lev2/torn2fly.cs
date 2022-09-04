using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torn2fly : MonoBehaviour
{
    public static float SpeedBig = 6.0f;
    public static float SpeedSmall = 4.5f;
    private Rigidbody2D rb2d;
    int round;
    // Start is called before the first frame update
    void GoEn()
    {
        rb2d.AddForce(new Vector2(16, 0));
        round = 0;

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
        if (round == 0)
        {
            if (rb2d.transform.position.y >= -3.0 & rb2d.transform.position.x >= 3.50)
            {
                vel.y = -SpeedBig;
                vel.x = -SpeedSmall;
                //vel.y = -6.0f;
                //vel.x = -4.5f;
                rb2d.velocity = vel;

            } else if (rb2d.transform.position.x >= -0.5 & rb2d.transform.position.x <= 3.5 & rb2d.transform.position.y <= 3.0)
            {

                vel.y = SpeedBig;
                vel.x = -SpeedSmall;
                //vel.y = 6.0f;
                //vel.x = -4.5f;


                rb2d.velocity = vel;
            } else if (rb2d.transform.position.x <= -0.5 & rb2d.transform.position.x >= -4.5 & rb2d.transform.position.y >= -3.0)
            {
                vel.y = -SpeedBig;
                vel.x = -SpeedSmall;
                //vel.y = -6.0f;
                //vel.x = -4.5f;

                rb2d.velocity = vel;
            } else if (rb2d.transform.position.x >= -8.5 & rb2d.transform.position.x <= -4.5 & rb2d.transform.position.y <= 3.0)
            {
                vel.y = SpeedBig;
                vel.x = -SpeedSmall;
                //vel.y = 6.0f;
                //vel.x = -4.5f;

                rb2d.velocity = vel;

            }
        if (rb2d.transform.position.x <= -8.0)
        {
            round = 1;
        }
        
        }

        
        
        if (round == 1)
        {
            if (rb2d.transform.position.x >= -8.5 & rb2d.transform.position.x <= -4.5 & rb2d.transform.position.y >= -3.0)
            {
                vel.y = -SpeedBig;
                vel.x = SpeedSmall;
                //vel.y = -6.0f;
                //vel.x = 4.5f;

                rb2d.velocity = vel;
            } else if (rb2d.transform.position.x <= -0.5 & rb2d.transform.position.x >= -4.5 & rb2d.transform.position.y <= 3.0)
            {
                vel.y = SpeedBig;
                vel.x = SpeedSmall;
                //vel.y = 6.0f;
            //vel.x = 4.5f;

            rb2d.velocity = vel;
            }
            else if (rb2d.transform.position.x >= -0.5 & rb2d.transform.position.x <= 3.5 & rb2d.transform.position.y >= -3.0)
            {
                vel.y = -SpeedBig;
                vel.x = SpeedSmall;
                //vel.y = -6.0f;
                //vel.x = 4.5f;

                rb2d.velocity = vel;
            }
            else if(rb2d.transform.position.y <= 3.0 & rb2d.transform.position.x >= 3.50 & rb2d.transform.position.x <= 7.50)
            {
                vel.y = SpeedBig;
                vel.x = SpeedSmall;
                //vel.y = 6.0f;
                //vel.x = 4.5f;
                rb2d.velocity = vel;

            }
            if (rb2d.transform.position.x >= 7.4)
            {
                round = 0;
                rb2d.transform.position = new Vector3(7.5f, 3.0f, 0.0f);
            }
        } 

    }
 }
