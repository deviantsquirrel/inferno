using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlmove : MonoBehaviour
{
    int dir = 1;
    float targetTime = 0.0f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controlLU.girlgo == 1)
        {
            targetTime += Time.deltaTime;
            if (transform.position.y > 0.31f && dir == 1)
            {
                animator.SetInteger("dir", 1);
                transform.position = new Vector2(transform.position.x, transform.position.y - 5.0f * Time.deltaTime);
                if (transform.position.y <= 0.31f)
                {
                    dir = 2;
                }
            }
            if (transform.position.x > 0.98f && dir == 2)
            {
                animator.SetInteger("dir", 2);
                transform.position = new Vector2(transform.position.x - 5.0f * Time.deltaTime, transform.position.y);
                if (transform.position.x <= 0.98f)
                {
                    dir = 0;
                    animator.SetInteger("dir", 3);
                }
            }


        }

        
    }
}
