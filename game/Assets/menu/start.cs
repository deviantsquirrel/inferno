using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public static int lives = 3;
    public static int level = 1;
    public Text diffi;
    public GameObject canva;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        level = 1;
        tornFly.forwardMovementSpeed = 10.0f;
        torn2fly.SpeedBig = 6.0f;
        torn2fly.SpeedSmall = 4.5f;
        roen4fly.sppedd = 8;
        canva.SetActive(false);
    }
    IEnumerator St1()
    {
        Debug.Log("here");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("lev1");

    }
    // Update is called once per frame
    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("start"))
        {
            canva.SetActive(true);
            StartCoroutine(St1());
            //SceneManager.LoadScene("lev1");
        }
        if (CrossPlatformInputManager.GetButtonDown("ChangeDif"))
        {
            if (diffi.text=="Hard")
            {
                diffi.text = "Medium";
                tornFly.forwardMovementSpeed = 10.0f/2;
                torn2fly.SpeedBig = 6.0f/2;
                torn2fly.SpeedSmall = 4.5f/2;
                roen4fly.sppedd = 4;
                fieldOFview.forwardMovementSpeed = 3.0f;
            }
            else if (diffi.text == "Medium")
            {
                diffi.text = "Baby";
                tornFly.forwardMovementSpeed = 10.0f / 4;
                torn2fly.SpeedBig = 6.0f / 4;
                torn2fly.SpeedSmall = 4.5f / 4;
                roen4fly.sppedd = 2;
                fieldOFview.forwardMovementSpeed = 1.0f;
            }
            else if (diffi.text == "Baby")
            {
                diffi.text = "Hard";
                tornFly.forwardMovementSpeed = 10.0f;
                torn2fly.SpeedBig = 6.0f;
                torn2fly.SpeedSmall = 4.5f;
                roen4fly.sppedd = 8;
                fieldOFview.forwardMovementSpeed = 10.0f;
            }
        }
        /*
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("lev1");
            Debug.Log("Pressed primary button.");

        }
           */ 
        
    }
}
