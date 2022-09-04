using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class hero : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveRight = KeyCode.A;
    public KeyCode moveLeft = KeyCode.D;
    public float speed = 5.0f;
    public float boundY = 3.9f;
    public float boundD = -3.6f;
    public float boundX = 8.3f;
    public Transform RightTransf;
    private Animator animator;
    public static int dir;
    public int liz;
    public int butpr = 0;

    public Button m_YourFirstButton;
    public Rigidbody2D platf;
    public Transform newtarget;
    bool FoundTarget = false;
    int plata = 0;

    public LayerMask groundLayer;

    public float screenHeight = 1920f;
    public float screenWidth = 1080f;
    public float targetAspect = 9f / 16f;
    public float orthographicSize;
    private Camera mainCamera;

    public GameObject canvaEnd;
    public GameObject rule;

    IEnumerator St1(string www)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(www);
    }
    
    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.3f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        direction = Vector2.left;
        hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        direction = Vector2.right;
        hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        direction = Vector2.up;
        hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        canvaEnd.SetActive(false);

        rb2d = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();

        mainCamera = Camera.main;
        orthographicSize = mainCamera.orthographicSize;

        // Calculating ortographic width
        float orthoWidth = orthographicSize / screenHeight * screenWidth;
        // Setting aspect ration
        orthoWidth = orthoWidth / (targetAspect / mainCamera.aspect);
        // Setting Size
        Camera.main.orthographicSize = (orthoWidth / Screen.width * Screen.height);

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        liz = start.lives;
        //start.level = 3;/////////////////
        if (hitInfo.gameObject.tag == "huricane")
        {
            start.lives-=1;
            
            Debug.Log(hitInfo.name);
            if (start.lives > 0)
            {
                if (start.level==2)
                {
                    SceneManager.LoadScene("SampleScene");

                }
                if (start.level == 3)
                {
                    SceneManager.LoadScene("lev3");

                }
                if (start.level == 4)
                {
                    SceneManager.LoadScene("lev4");

                }
                if (start.level == 5)
                {
                    SceneManager.LoadScene("lev5");

                }
                if (start.level == 6)
                {
                    SceneManager.LoadScene("lev6");

                }
                if (start.level == 7)
                {
                    SceneManager.LoadScene("lev7");

                }

            }
            else
            {
                start.level = 0;
                SceneManager.LoadScene("menu");
            }
            

        }

       

        if (hitInfo.gameObject.tag == "platf1")
        {
            this.transform.parent = null;
            Debug.Log("colide ");
            this.transform.parent = hitInfo.transform;
        }

        


        if (hitInfo.gameObject.tag == "dorl1")
        {
            canvaEnd.SetActive(true);
            start.level += 1;
            Debug.Log(hitInfo.name);
            StartCoroutine(St1("SampleScene"));
        }
        if (hitInfo.gameObject.tag == "door")
        {
            canvaEnd.SetActive(true);
            start.level += 1;
            StartCoroutine(St1("lev3"));
        }
        if (hitInfo.gameObject.tag == "dorl3")
        {
            canvaEnd.SetActive(true);
            start.level += 1;
            start.lives += 1;
            StartCoroutine(St1("lev4"));
        }
        if (hitInfo.gameObject.tag == "dor4")
        {
            rule.SetActive(false);
            canvaEnd.SetActive(true);
            start.level += 1;
            StartCoroutine(St1("lev5"));
        }
        if (hitInfo.gameObject.tag == "dor5")
        {
            canvaEnd.SetActive(true);
            start.level += 1;
            StartCoroutine(St1("lev6"));
        }

    }
    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;

        if(controlLU.girlgo == 1)
        {
            vel.y = 0.0f;
            vel.x = 0.0f;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        if (pos.y < -4.5f)
        {
            pos.y = -4.5f;
        }
        transform.position = pos;


        if (controlLU.girlgo == 1)
        {
            vel.y = 0.0f;
            vel.x = 0.0f;
        }
        rb2d.velocity = vel;
        

        if (pos.x > 8.5f)
        {
            pos.x = 8.5f;
        }
        else if (pos.x < -8.5f)
        {
            pos.x = -8.5f;
        }
        transform.position = pos;


        if(start.level == 4)
        {
            if (IsGrounded())
            {
               

            }
            else
            {
                Debug.Log("Dead");
                start.lives -= 1;
                if (start.lives > 0)
                {
                    SceneManager.LoadScene("lev4");
                }
                else
                {
                    SceneManager.LoadScene("menu");
                }
                    

            }

        }

        if (orph.talking == 1)
        {
            pos.x = -8.0f;
            pos.y = -0.3f;
            Debug.Log("Stop!!!!!!!!11");
        }
        transform.position = pos;

        //start.level = 5;
        if (scenrmann.progres == 5|| scenrmann.progres == 8 || scenrmann.progres == 9)
        {
            pos.x = 5.77f;
            pos.y = -0.54f;
            //Debug.Log("Stop!!!!!!!!11");
        }
        if (scenrmann.progres == 6|| scenrmann.progres == 1)
        {
            pos.x = -6.56f;
            pos.y = 2.74f;
            //Debug.Log("Stop!!!!!!!!11");
        }
        transform.position = pos;
        if (scenrmann.progres == 7 || scenrmann.progres == 2)
        {
            pos.x = -1.27f;
            pos.y = 2.54f;
            //Debug.Log("Stop!!!!!!!!11");
        }
        transform.position = pos;




    }
    


    public void leftPr(int ar)
    {
        butpr = ar;
        //sto();

        //Input.GetKey(moveRight)(true);
    }
    IEnumerator sto()
    {
        yield return new WaitForSeconds(0.5f);
        butpr = 0;
    }
}
