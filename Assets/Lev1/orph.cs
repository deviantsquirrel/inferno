using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orph : MonoBehaviour
{
    public float forwardMovementSpeed = 4.0f;
    public static int talking = 1;
    private Rigidbody2D rb2d;
    private Animator animator;
    public dialog Dialog;
    public GameObject canva;
    public GameObject canvaW;
    int forw = 0;
    int dir = 0;
    void GoEn()
    {
        rb2d.AddForce(new Vector2(16, 0));
       

    }
    public void TriggerDialog()
    {
        FindObjectOfType<Lev1Dialog>().StartDialog(Dialog);
    }


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
        talking = 1;
        Invoke("GoEn", 1);
        canva.SetActive(false);
        canvaW.SetActive(false);
       

    }
    void StartDio()
    {
        canva.SetActive(true);
        Debug.Log(Dialog.sentenses[0]);

        
        FindObjectOfType<Lev1Dialog>().StartDialog(Dialog);


    }
        // Update is called once per frame
        void Update()
    {
        Vector2 vel;
        Debug.Log(talking);
        if (rb2d.transform.position.y >= 0 && rb2d.transform.position.x == 5.0f)
        {
            vel.y = -forwardMovementSpeed;
            vel.x = 0.0f;
            animator.SetInteger("dir", 1);
            animator.SetFloat("speed", -4);

            rb2d.velocity = vel;

        }

        if (rb2d.transform.position.y <= 0.0 && rb2d.transform.position.x >= -7.3)
        {
            //Debug.Log(rb2d.transform.position.x >= -7.0);
            vel.y = 0.0f;
            vel.x = -forwardMovementSpeed;
            animator.SetInteger("dir", 2);
            animator.SetFloat("speed", vel.x);

            rb2d.velocity = vel;

        }
        if (rb2d.transform.position.x <= -7.3)
        {

            vel.y = 0.0f;
            vel.x = 0.0f;
            animator.SetInteger("dir", 2);
            animator.SetFloat("speed", vel.x);

            rb2d.velocity = vel;
            if (forw == 0)
            {
                StartDio();
                forw = 1;
            }
            
            
        }
        if (Lev1Dialog.talki == 0)
        {
            canva.SetActive(false);
            canvaW.SetActive(true);
        }


       
    }
}
