using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightGGG : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float range;

    [SerializeField]
    float speed;

    [SerializeField]
    Transform castP;

    Rigidbody2D rb2d;

    bool isFacingUp;
    public int forw = 0;
    private Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (forw == 0)
        {
            transform.position = new Vector2(transform.position.x + 5.0f * Time.deltaTime, transform.position.y );
            animator.SetInteger("dir", 1);
            if (transform.position.x >= 7.5)
            {
                forw = 1;
                transform.localScale = new Vector3(-0.7f, 0.7f, 1f);
                isFacingUp = false;
            }
        }

        if (forw == 1)
        {
            transform.position = new Vector2(transform.position.x - 5.0f * Time.deltaTime, transform.position.y );
            animator.SetInteger("dir", 0);
            if (transform.position.x <= 1.0)
            {
                forw = 0;
                transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                isFacingUp = true;
            }
        }
        /*
        if (transform.position.y > player.position.y)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingUp = false;
        }
        else
        {
            transform.localScale = new Vector3(1, -1, 1);
            isFacingUp = true;
        }
        */
        if (CanSeePlayer(range))
        {
            Chase();
            Debug.Log("Goo");
        }
        else
        {
            Stopp();
        }
    }

    bool CanSeePlayer(float diat)
    {
        bool var = false;
        float castDist = diat;

        if (isFacingUp)
        {
            castDist = -diat;
        }

        Vector2 endP = castP.position + Vector3.left * castDist;
        RaycastHit2D hit = Physics2D.Linecast(castP.position, endP, 1 << LayerMask.NameToLayer("player"));
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.tag);
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                var = true;
                //Debug.Log("grfvsdfbdf");
            }
            else
            {
                var = false;
            }
            Debug.DrawLine(castP.position, endP, Color.yellow);
        }


        return var;

    }

    void Chase()
    {
        if (transform.position.x > player.position.x)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y );
            Debug.Log("Here");
            //transform.localScale = new Vector3(1, 1, 1);
            //isFacingUp = false;

        }
        else
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y );
            Debug.Log("Here");
            //transform.localScale = new Vector3(1, -1, 1);
            //isFacingUp = true;

        }
        //if(transform.position.x)
        //rb2d.velocity = new Vector2(-speed, 0);
        //transform.localScale = new Vector2(-1, 1);
    }

    void Stopp()
    {
        //if(transform.position.x)
        rb2d.velocity = new Vector2(0, 0);
    }
}
