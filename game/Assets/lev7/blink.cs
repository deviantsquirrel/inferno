using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    public GameObject stop;
    float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        on.SetActive(false);
        off.SetActive(true);
        stop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //Debug.Log(time);
        if (time < 0.1f)
        {
            on.SetActive(true);
            Debug.Log("Here");
        }
            if (time> 0.1f&& time < 0.2f)////
        {
            on.SetActive(false);
            //off.SetActive(true);
            
        }
        if (time>0.2 && time < 0.5)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
            if (time > 0.5f && time < 0.6f)//////
        {
            on.SetActive(false);
            //off.SetActive(true);
            
        }
        if (time > 0.6 && time < 0.7)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
            if (time > 0.7f && time < 0.8f)///////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 0.8 && time < 0.9)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 0.9f && time < 1.2f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }



        if (time > 1.2 && time < 1.3)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 1.3 && time < 1.4f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 1.4 && time < 1.5)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 1.5 && time < 1.6f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 1.6 && time < 1.9)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 1.9 && time < 2.0f)/////
        {
            on.SetActive(false);
            //.SetActive(true);

        }
        if (time > 2.0 && time < 2.3)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 2.3 && time < 2.6f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }/*
        if (time > 2.4 && time < 2.7)
        {
            off.SetActive(false);
            on.SetActive(true);
        }

        */


        if (time > 2.6 && time < 2.9)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 2.9 && time < 3.0f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 3.0 && time < 3.1)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 3.1 && time < 3.2f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 3.2 && time < 3.3)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 3.3 && time < 3.4f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 3.4 && time < 3.5)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 3.5 && time < 3.8f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }/*
        if (time > 3.6 && time < 3.9)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        */


        if (time > 3.8 && time < 4.1)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 4.1 && time < 4.2f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 4.2 && time < 4.5)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 4.5 && time < 4.6f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 4.6 && time < 4.9)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 4.9 && time < 5.2f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        ////////////////// 4

        if (time > 5.2 && time < 5.3)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 5.3 && time < 5.4f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 5.4 && time < 5.7)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 5.7 && time < 5.8f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 5.8 && time < 6.1)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 6.1 && time < 6.4f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        ///////////////// 5

        if (time > 6.4 && time < 6.7)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 6.7 && time < 6.8f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 6.8 && time < 6.9)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 6.9 && time < 7.0f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 7.0 && time < 7.1)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 7.1 && time < 7.2f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }
        if (time > 7.2 && time < 7.5)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 7.5 && time < 7.8f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }

        //////////////// 6
        

        if (time > 7.8 && time < 8.1)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 8.1 && time < 8.2f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 8.2 && time < 8.5)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 8.5 && time < 8.6f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 8.6 && time < 8.7)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 8.7 && time < 8.8f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }
        if (time > 8.8 && time < 8.9)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 8.9 && time < 9.0f)/////
        {
            on.SetActive(false);
          //  off.SetActive(true);

        }
        if (time > 9.0 && time < 9.3)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 9.3 && time < 9.4f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }
        if (time > 9.4 && time < 9.7)
        {
           // off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 9.7 && time < 10.4f)/////
        {
            on.SetActive(false);
          //  off.SetActive(true);

        }

        //////word

        if (time > 10.4 && time < 10.7)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 10.7 && time < 10.8f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 10.8 && time < 11.1)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 11.1 && time < 11.2f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 11.2 && time < 11.5)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 11.5 && time < 11.6f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }
        if (time > 11.6 && time < 11.7)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 11.7 && time < 12.0f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }


        if (time > 12.0 && time < 12.3)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 12.3 && time < 12.6f)/////
        {
            on.SetActive(false);
            //off.SetActive(true);

        }


        if (time > 12.6 && time < 12.9)
        {
            //off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 12.9 && time < 13.0f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }
        if (time > 13.0 && time < 13.3)
        {
          //  off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 13.3 && time < 13.4f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }
        if (time > 13.4 && time < 13.7)
        {
          //  off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 13.7 && time < 14.4f)/////
        {
            on.SetActive(false);
           // off.SetActive(true);

        }
        //////word


        /*

        if (time > 14.5 && time < 14.8)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 14.8 && time < 14.9f)/////
        {
            on.SetActive(false);
            off.SetActive(true);

        }
        if (time > 14.9 && time < 15.0)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 15.0 && time < 15.1f)/////
        {
            on.SetActive(false);
            off.SetActive(true);

        }
        if (time > 15.1 && time < 15.2)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 15.2 && time < 15.5f)/////
        {
            on.SetActive(false);
            off.SetActive(true);

        }




        if (time > 15.5 && time < 15.6)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 15.6 && time < 15.7f)/////
        {
            on.SetActive(false);
            off.SetActive(true);

        }
        if (time > 15.7 && time < 16.0)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 16.0 && time < 16.1f)/////
        {
            on.SetActive(false);
            off.SetActive(true);

        }
        if (time > 16.1 && time < 16.4)
        {
            off.SetActive(false);
            on.SetActive(true);
        }
        if (time > 16.4 && time < 16.7f)/////
        {
            on.SetActive(false);
            off.SetActive(true);

        }*/
    }
}
