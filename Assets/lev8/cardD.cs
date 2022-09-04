using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cardD : MonoBehaviour
{
    public GameObject xx;
    public GameObject weapon;
    public GameObject[] weapons;
    
    // Start is called before the first frame update
    float targetTime = 1.7f;

    void Start()
    {
        xx.SetActive(false);
        
    }
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.1f && targetTime > 0.0f)
        {
            //Debug.Log("Time is up");
            xx.SetActive(true);
        }
       // Debug.Log("pairs"+controller.pairs);
       /*
        if (Input.touchCount >0)
        {
            Debug.Log("cliced");
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("cliced");
                //OnM();
            }
        }
       */
    }


    public void OnMouseDown()
    {
        controller.opened++;
        
        Debug.Log(xx.gameObject.tag);
        Debug.Log(controller.opened);
        if (xx.gameObject.tag == "1")
        {
            Debug.Log("cheak");
            if (controller.opened == 1)
            {
                controller.cliced = 1;
            } else { 
                if(controller.cliced == 1)
                {
                    Debug.Log("Right");
                    controller.pairs++;
                    Close("1");
                }
                else
                {
                    controller.opened = 0;
                    
                    Debug.Log("Wrong");
                    start.lives--;
                    SceneManager.LoadScene("lev8");

                }
            }
            
        }
        if (xx.gameObject.tag == "2")
        {
            if (controller.opened == 1)
            {
                controller.cliced = 2;
            }
            else
            {
                if (controller.cliced == 2)
                {
                    Debug.Log("Right");
                    controller.pairs++;
                    Close("2");
                }
                else
                {
                    controller.opened = 0;
                    
                    Debug.Log("Wrong");
                    start.lives--;
                    SceneManager.LoadScene("lev8");
                }
            }
        }
        if (xx.gameObject.tag == "3")
        {
            if (controller.opened == 1)
            {
                controller.cliced = 3;
            }
            else
            {
                if (controller.cliced == 3)
                {
                    Debug.Log("Right");
                    controller.pairs++;
                    Close("3");
                }
                else
                {
                    controller.opened = 0;
                    
                    Debug.Log("Wrong");
                    start.lives--;
                    SceneManager.LoadScene("lev8");
                }
            }
        }
        if (xx.gameObject.tag == "4")
        {
            if (controller.opened == 1)
            {
                controller.cliced = 4;
            }
            else
            {
                if (controller.cliced == 4)
                {
                    Debug.Log("Right");
                    controller.pairs++;
                    Close("4");
                }
                else
                {
                    controller.opened = 0;
                    
                    Debug.Log("Wrong");
                    start.lives--;
                    SceneManager.LoadScene("lev8");
                }
            }
        }
        xx.SetActive(false);
    }
    

    public void Close(string rr)
    {
        weapons = GameObject.FindGameObjectsWithTag(rr);

        foreach (GameObject weapon in weapons)
        {
            weapon.SetActive(false);
        }
        
        controller.opened = 0;

    }


    }
