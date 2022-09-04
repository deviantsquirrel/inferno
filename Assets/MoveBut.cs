using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveBut : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float dirX;
    public float dirY;
    private float movespeed = 5.0f;
    private Animator animator;
    public static int dir = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * movespeed;
        rb.velocity = new Vector2(dirX, dirY);

        dirY = CrossPlatformInputManager.GetAxis("Vertical") * movespeed;
        //rb.velocity = new Vector2( 0f, dirY);

        //var vel = rb.velocity;
        //Debug.Log(animator);
        if (dirX < 0)
        {
            animator.SetInteger("dir", 3);
            dir = 3;
            animator.SetInteger("gox", -3);
        }
        else if (dirX > 0)
        {
            animator.SetInteger("dir", 1);
            animator.SetInteger("gox", 3);
            dir = 1;
        }
        else
        {
            animator.SetInteger("gox", 0);
        }

        if (dirY > 0)
        {
            animator.SetInteger("dir", 4);
            animator.SetInteger("goy", 3);
            dir = 4;
        }
        else if (dirY < 0)
        {
            animator.SetInteger("dir", 2);
            animator.SetInteger("goy", -3);
            dir = 2;
        }
        else
        {
            animator.SetInteger("goy", 0);
        }


    }
}
