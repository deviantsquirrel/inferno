using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public dialog Dialog1;
    public static int activD = 0;
    public GameObject canvaTalk;
    public GameObject canvaMove;
    public GameObject canvaEnd;
    float targetTime = 0.0f;
    int dir = 1;
    int stand = 0;
    int standQ = 0;
    // Start is called before the first frame update
    void Start()
    {
        canvaMove.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (controlLU.girlgo == 1)
        {
            targetTime += Time.deltaTime;

            if (transform.position.y > 0.0f)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 5.0f * Time.deltaTime);
                if (transform.position.y <= 0.0f)
                {
                    if (standQ == 0)
                    {
                        standQ = 1;
                        dir = 2;
                    }
                }
            }
            if (transform.position.y < 0.0f)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + 5.0f * Time.deltaTime);
                if (transform.position.y >= 0.0f)
                {
                    if (standQ == 0)
                    {
                        standQ = 1;
                        dir = 2;
                    }
                    
                }
            }
            if (transform.position.x > -1.38f)
            {
                transform.position = new Vector2(transform.position.x - 5.0f * Time.deltaTime, transform.position.y);
                if (transform.position.x <= -1.38f)
                {
                    if (stand == 0)
                    {
                        stand = 1;
                        dir = 3;
                    }
                    
                }
            }
            if (transform.position.x < -1.38f)
            {
                transform.position = new Vector2(transform.position.x + 5.0f * Time.deltaTime, transform.position.y);
                if (transform.position.x >= -1.38f)
                {
                    if (stand == 0)
                    {
                        stand = 1;
                        dir = 3;
                    }
                }
            }

            if (dir == 3)
            {
                dir = 4;
                Debug.Log("In position");
                activD = 1;
                FindObjectOfType<DialogSev>().StartDialog(Dialog1);
                canvaTalk.SetActive(true);
                canvaMove.SetActive(false);

            }

            Debug.Log("dir=" + dir+ "  activD=" + activD);

            if(dir == 4)
            {
                if (activD == 0)
                {
                    canvaEnd.SetActive(true);
                }
            }

        }

        


    }
}
