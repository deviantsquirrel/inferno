using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTriger : MonoBehaviour
{
    public dialog Dialog;
    //Dialog.name = "kiran";
    //public string[] Dialog;
    //[0] = "Hello";

    public void TriggerDialog()
    {
        FindObjectOfType<Lev1Dialog>().StartDialog(Dialog);
    }

    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(Dialog.sentenses[0]);

        if (hitInfo.gameObject.tag == "orphey")
        {
            Debug.Log("here");
            FindObjectOfType<Lev1Dialog>().StartDialog(Dialog);
        }
    }
}