using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class DialogSev : MonoBehaviour
{
    public Text nemeText;
    public Text diaText;
    int nnn = 0;
    public string name_1;
    public string name_2;

    bool empt = false;

    private Queue<string> sentenses;
    // Start is called before the first frame update
    void Start()
    {
        sentenses = new Queue<string>();
    }

    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("continue"))
        {
            DisplayNext();
        }

        if (CrossPlatformInputManager.GetButtonDown("end"))
        {
            EndDialog();
        }
    }

    // Update is called once per frame
    public void StartDialog(dialog dia)
    {
        nnn = 0;
        empt = false;
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

    public void StartEmpt(string nam)
    {
        nnn = 0;

        Debug.Log("Starrt");
        diaText.text = "...";
        empt = true;
    }
    public void CCCCCC()
    {
        Application.Quit();
    }

        public void DisplayNext()
    {
        Debug.Log("Ujdjhb");
        if (nnn % 2 == 0)
        {
            nemeText.text = name_2;
        }

        else
        {
            nemeText.text = name_1;
        }
        nnn++;
        Debug.Log("Add");
        Debug.Log(sentenses.Count);
        if (sentenses.Count <= 0)
        {
            //orph.talking = 0;
            EndDialog();
            return;
        }
        if (empt)
        {
            empt = false;
            Debug.Log("End");
            Debug.Log("Ending dia");
            EndDialog();
            
            return;
        }
        if (nnn == 8&& name_2=="Эмма")
        {
            nemeText.text ="";
        }
        if (nnn == 8 && name_2 == "Виктор")
        {
            nemeText.text = "";
        }
        if (nnn == 3 && name_1 == "Абаддон")
        {
            nemeText.text = "";
            nnn++;
        }
        if (nnn == 7 && name_1 == "Абаддон")
        {
            nemeText.text = "Абаддон";
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

        foreach (char letter in senten.ToCharArray())
        {
            diaText.text += letter;
            yield return new WaitForSeconds(0.006f); ;
        }
    }

    public void EndDialog()
    {
        Debug.Log("End");
        diaText.text = "";
        nemeText.text = "";
        scenrmann.activD = 0;
        ending.activD = 0;
    }
}
