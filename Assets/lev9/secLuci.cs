using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secLuci : MonoBehaviour
{
    float targetTime = 1.0f;
    int dir = 2;
    float last = 0;
    public GameObject plye;
    public GameObject bulet;
    public static int Aliv = 1;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        targetTime += Time.deltaTime;
        if (targetTime > last)
        {
            GameObject bul = Instantiate(bulet);

            bul.SetActive(true);
            last += 1.0f;
        }

        if (transform.position.x < 8.2f && dir == 1)
        {
            transform.position = new Vector2(transform.position.x+ 5.0f * Time.deltaTime, transform.position.y );
            if (transform.position.x >= 8.2f)
            {
                dir = 2;
            }
        }
        if (transform.position.x > -8.0f && dir == 2)
        {
            transform.position = new Vector2(transform.position.x - 5.0f * Time.deltaTime, transform.position.y );
            if (transform.position.x <= -8.0f)
            {
                dir = 1;
            }
        }

        if (Aliv == 0)
        {
            plye.SetActive(false);
        }
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Hit");
        //start.level = 3;/////////////////
        if (hitInfo.gameObject.tag == "fire")
        {
            controlLU.LLives--;
            Debug.Log(controlLU.LLives);
        }
    }
}
