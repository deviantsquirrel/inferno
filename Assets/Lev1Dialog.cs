using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Lev1Dialog : MonoBehaviour
{
    public Text nemeText;
    public Text diaText;
    int nnn = 0;
    public string name_1;
    public string name_2;
    public static int talki = 1;

    private Queue <string> sentenses;
    // Start is called before the first frame update
    void Start()
    {
        sentenses = new Queue<string>();
        talki = 1;
    }


    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("continue"))
        {
            DisplayNext();
        }
        if (CrossPlatformInputManager.GetButtonDown("end"))
        {
            orph.talking = 0;
            talki = 0;
            Debug.Log("Skipped");
            EndDialog();
        }
    }
        // Update is called once per frame
        public void StartDialog(dialog dia)
    {
        orph.talking = 1;
        Debug.Log("Starrt");
        nemeText.text = dia.name;
        sentenses.Clear();
        name_1 = dia.name;
        name_2 = dia.name_2;
        foreach (string senten in dia.sentenses)
        {
            
            Debug.Log(nnn);
            sentenses.Enqueue(senten);
        }
        DisplayNext();
    }

    

    public void DisplayNext()
    {
        if (nnn % 2 == 0)
        {
            nemeText.text = name_2;
            }
        
        else
        {
            nemeText.text = name_1;
        }
        if (nnn == 5)
        {
            nemeText.text = "  ";
        }
        nnn++;
        if (sentenses.Count == 0)
        {
            orph.talking = 0;
            EndDialog();
            return;
        }
        string senten = sentenses.Dequeue();
        diaText.text = senten;
        
        //Debug.Log(senten);
        StopAllCoroutines();
        //StartCoroutine(Typee(senten));
    }

    IEnumerator Typee(string senten)
    {
        diaText.text = "";

        foreach(char letter in senten.ToCharArray())
        {
            diaText.text += letter;
            yield return new WaitForSeconds(0.006f); ;
        }
    }

    public void EndDialog()
    {
        //Debug.Log("End");
        diaText.text = "";
        nemeText.text = "";
        talki = 0;
    }
}
