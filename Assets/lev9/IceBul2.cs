using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBul2 : MonoBehaviour
{
    public GameObject plye;
    public GameObject me;
    int direct = 2;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(plye.transform.position.x,
                                        plye.transform.position.y,
                                        plye.transform.position.z
                                        );

        transform.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 8.0f * Time.deltaTime);
        if (controlLU.girlgo == 1)
        {
            Destroy(me);
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
