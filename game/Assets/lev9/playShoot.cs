using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playShoot : MonoBehaviour
{
    public GameObject bulet;
    public KeyCode sh = KeyCode.RightShift;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(sh))
        {
            
            Debug.Log("Shoot");
            GameObject bul = Instantiate(bulet);
            
            bul.SetActive(true);
            //Debug.Log("dir"+ 4);

        }
        */
        if (CrossPlatformInputManager.GetButtonDown("shoot"))
        {
            GameObject bul = Instantiate(bulet);

            bul.SetActive(true);
        }
    }
}
