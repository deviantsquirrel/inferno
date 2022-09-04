using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hearts : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public int liz;
    // Start is called before the first frame update
    void Start()
    {
        liz = start.lives;
        Heart1.SetActive(false);
        Heart2.SetActive(false);
        Heart3.SetActive(false);
        if (liz > 0)
        {
            Heart1.SetActive(true);
        }
        if (liz > 1)
        {
            Heart2.SetActive(true);
        }
        if (liz > 2)
        {
            Heart3.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (start.lives < 1)
        {
            Heart1.SetActive(false);
            start.level = 0;
            SceneManager.LoadScene("menu");
        }
        if (start.lives < 2)
        {
            Heart2.SetActive(false);
        }
        if (start.lives < 3)
        {
            Heart3.SetActive(false);
        }

    }
    
}
