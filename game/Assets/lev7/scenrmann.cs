using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenrmann : MonoBehaviour
{
    public static int progres = 0; 
    public static int stop = 0;
    public static int activD = 0;
    public GameObject canva;
    public GameObject canvaMove;
    public GameObject canvaTalk;
    public GameObject canva_2;
    public GameObject canva_3;

    public static int Solprogres = 0;
    public dialog Dialog1;
    public dialog Dialog2;
    public dialog Dialog3;
    public dialog Dialog4;
    public dialog Dialog5;

    public dialog Dialog6;
    public dialog Dialog7;

    public dialog GetBox;
    public GameObject canvaEnd;
    public static int colWork = 1;
    // Start is called before the first frame update
    void Start()
    {
        canvaEnd.SetActive(false);
        Solprogres = 0;
        progres = 0;
        canvaTalk.SetActive(true);

    }

    IEnumerator St1()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("lev8");
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (colWork == 1)
        {
            if (hitInfo.gameObject.tag == "aba")
            {
                if (Solprogres == 0)
                {
                    canvaMove.SetActive(false);
                    progres = 5;
                    activD = 1;
                    FindObjectOfType<DialogSev>().StartDialog(Dialog1);
                    Solprogres = 1;
                    colWork = 0;
                }
                if (Solprogres == 3)
                {
                    canvaMove.SetActive(false);
                    progres = 8;
                    activD = 1;
                    FindObjectOfType<DialogSev>().StartDialog(Dialog6);
                    colWork = 0;

                }
                if (Solprogres == 4)
                {
                    canvaMove.SetActive(false);
                    progres = 9;
                    activD = 1;
                    FindObjectOfType<DialogSev>().StartDialog(Dialog7);
                    //Solprogres = 5;
                    colWork = 0;

                }

            }
            if (hitInfo.gameObject.tag == "bodyguard")
            {

                if (Solprogres == 1)
                {
                    canvaMove.SetActive(false);
                    progres = 6;
                    activD = 1;
                    FindObjectOfType<DialogSev>().StartDialog(Dialog2);
                    colWork = 0;

                }
                else
                {
                    canvaMove.SetActive(false);
                    FindObjectOfType<DialogSev>().StartEmpt("Эмма");

                    progres = 6;
                    activD = 1;
                    //FindObjectOfType<DialogSev>().StartDialog(Dialog3);
                    colWork = 0;
                }


            }
            if (hitInfo.gameObject.tag == "partner")
            {
                canvaMove.SetActive(false);
                if (Solprogres == 2)
                {
                    progres = 7;
                    activD = 1;
                    FindObjectOfType<DialogSev>().StartDialog(Dialog5);
                    colWork = 0;

                }
                else
                {
                     canvaMove.SetActive(false);
                    progres = 7;
                    activD = 1;
                    FindObjectOfType<DialogSev>().StartEmpt("Виктор");
                    colWork = 0;
                }


            }
            if (hitInfo.gameObject.tag == "dor7")
            {
                if (Solprogres == 5)
                {
                    canvaEnd.SetActive(true);
                    start.level += 1;
                    Debug.Log(hitInfo.name);
                    StartCoroutine(St1());

                }


            }
        }
       
    }
        // Update is called once per frame
        void Update()
    {
        Debug.Log(progres);
        Debug.Log(Solprogres);



        if (progres == 1)
        {
            canva.SetActive(true);
            
        }
        else
        {
            canva.SetActive(false);
        }
        if (progres == 2)
        {
            canva_2.SetActive(true);
            
        }
        else
        {
            canva_2.SetActive(false);
        }
        if (progres == 3)
        {
            canva_3.SetActive(true);
           
        }
        else
        {
            canva_3.SetActive(false);
        }



        if (progres == 5)
        {
            canvaTalk.SetActive(true);
            Debug.Log("Here");
            if (activD == 0)
            {
                progres = 0;
                colWork = 1;
            }
            //progres = 6;
        }
       
        if (progres == 6)
        {
            canvaTalk.SetActive(true);
            Debug.Log("Talk");
            if (activD == 0)
            {
                progres = 0;
                colWork = 1;
                if (Solprogres == 1)
                {
                    colWork = 0;
                    progres = 1;
                    Solprogres = 2;
                }
            }
            
        }
        if (progres == 7)
        {
            canvaTalk.SetActive(true);
            if (activD == 0)
            {
                progres = 0;
                colWork = 1;
                if (Solprogres == 2)
                {
                    colWork = 0;
                    progres = 2;
                    Solprogres = 3;
                }
            }

        }
        if (progres == 8)
        {
            canvaTalk.SetActive(true);
            if (activD == 0)
            {
                progres = 0;
                colWork = 1;
                if (Solprogres == 3)
                {
                    colWork = 0;
                    progres = 3;
                    Solprogres = 4;
                }
            }

        }
        if (progres == 9)
        {
            canvaTalk.SetActive(true);
            if (activD == 0)
            {
                progres = 0;
                colWork = 1;
                if (Solprogres == 4)
                {
                    //colWork = 0;
                    progres = 0;
                    Solprogres = 5;
                }
            }

        }
        if (progres == 0|| progres == 1)
        {
            canvaTalk.SetActive(false);
            canvaMove.SetActive(true);
        }
    }
}
