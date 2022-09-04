using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buletFire : MonoBehaviour
{
    public GameObject plye;
    int direct = 2;
    public GameObject me;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(plye.transform.position.x,
                                        plye.transform.position.y,
                                        plye.transform.position.z
                                        );
        if (MoveBut.dir != 0)
        {
            direct = MoveBut.dir;
        }
        
        if (direct == 2)
        {
            transform.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
        }
        else if(direct == 4)
        {
            transform.transform.Rotate(0.0f, 0.0f, -90.0f, Space.World);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (direct == 1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.position = new Vector2(transform.position.x + 8.0f * Time.deltaTime, transform.position.y);

        }
        else if (direct == 2)
        {
            
            transform.position = new Vector2(transform.position.x, transform.position.y - 8.0f * Time.deltaTime);
        }
        else if (direct == 3)
        {
            transform.position = new Vector2(transform.position.x - 8.0f * Time.deltaTime, transform.position.y);
        }
        else if (direct == 4)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 8.0f * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "wall")
        {
            Destroy(me);
        }
    }
}
