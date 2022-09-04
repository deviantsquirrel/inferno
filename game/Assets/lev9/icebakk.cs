using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icebakk : MonoBehaviour
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
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x- 5.0f * Time.deltaTime, transform.position.y );
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
