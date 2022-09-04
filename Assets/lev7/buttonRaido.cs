using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class buttonRaido : MonoBehaviour
{
    public GameObject dagaz;
    public GameObject isa;
    public GameObject ansuz;
    public GameObject laguz;
    public GameObject uruz;
    public GameObject sowilo;
    public GameObject ingwaz;
    public GameObject othila;
    public GameObject perthro;
    public GameObject raidho;
    public GameObject tiwaz;
    public GameObject eihwaz;
    public GameObject jera;
    public int letterCount = 0;

    public Transform parent;

    public GameObject weapon;
    public GameObject[] weapons;
    public GameObject canva;
    bool rightIsIt1 = false;
    bool rightIsIt2 = false;
    bool rightIsIt3 = false;
    bool rightIsIt4 = false;


    public GameObject Pos2;
    public GameObject Pos3;
    public GameObject Pos4;

    void Start()
    {
        dagaz.SetActive(false);
        isa.SetActive(false);
        ansuz.SetActive(false);
        laguz.SetActive(false);
        uruz.SetActive(false);
        sowilo.SetActive(false);
        ingwaz.SetActive(false);
        othila.SetActive(false);
        perthro.SetActive(false);
        raidho.SetActive(false);
        tiwaz.SetActive(false);
        eihwaz.SetActive(false);
        jera.SetActive(false);
    }


    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("isa"))
        {
            isaF();
        }
        if (CrossPlatformInputManager.GetButtonDown("dagaz"))
        {
            dagazF();
        }
        if (CrossPlatformInputManager.GetButtonDown("ansuz"))
        {
            ansuzF();
        }
        if (CrossPlatformInputManager.GetButtonDown("laguz"))
        {
            laguzF();
        }
        if (CrossPlatformInputManager.GetButtonDown("uruz"))
        {
            uruzF();
        }
        if (CrossPlatformInputManager.GetButtonDown("sowilo"))
        {
            sowiloF();
        }
        if (CrossPlatformInputManager.GetButtonDown("ingwaz"))
        {
            ingwazF();
        }
        if (CrossPlatformInputManager.GetButtonDown("othila"))
        {
            othilaF();
        }
        if (CrossPlatformInputManager.GetButtonDown("perthro"))
        {
            perthroF();
        }
        if (CrossPlatformInputManager.GetButtonDown("raidho"))
        {
            raidhoF();
        }
        if (CrossPlatformInputManager.GetButtonDown("tiwaz"))
        {
            tiwazF();
        }
        if (CrossPlatformInputManager.GetButtonDown("eihwaz"))
        {
            eihwazF();
        }
        if (CrossPlatformInputManager.GetButtonDown("jera"))
        {
            jeraF();
        }
        if (CrossPlatformInputManager.GetButtonDown("clearr"))
        {
            clear();
        }
        if (CrossPlatformInputManager.GetButtonDown("cheak"))
        {
            cheak();
        }
    }



    public void clear()
    {
        weapons = GameObject.FindGameObjectsWithTag("letter");

        foreach (GameObject weapon in weapons)
        {
            weapon.SetActive(false);
        }
        letterCount = 0;
    }

    public void cheak()
    {
        if(rightIsIt1&& rightIsIt2&& rightIsIt3&& rightIsIt4)
        {
            scenrmann.progres = 0;
            scenrmann.colWork = 1;
            Debug.Log("Right");
            canva.SetActive(false);
            //Destroy(canva);
            
            //this.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong");
            start.lives--;
        }
        
    }


    public void dagazF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            dagaz.SetActive(true);

        } else if(letterCount == 2)
        {
            GameObject dagaz2 = Instantiate(dagaz);
            dagaz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            dagaz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            dagaz2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject dagaz3 = Instantiate(dagaz);
            dagaz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            dagaz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            dagaz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject dagaz4 = Instantiate(dagaz);
            dagaz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            dagaz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            dagaz4.SetActive(true);
        }
    }

    public void isaF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            isa.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject isa2 = Instantiate(isa);
            isa2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            isa2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            isa2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject isa3 = Instantiate(isa);
            isa3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            isa3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            isa3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject isa4 = Instantiate(isa);
            isa4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            isa4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            isa4.SetActive(true);
        }
    }

    public void ansuzF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            ansuz.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject ansuz2 = Instantiate(ansuz);
            ansuz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ansuz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            ansuz2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject ansuz3 = Instantiate(ansuz);
            ansuz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ansuz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            ansuz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject ansuz4 = Instantiate(ansuz);
            ansuz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ansuz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            ansuz4.SetActive(true);
        }
    }

    public void uruzF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            uruz.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject uruz2 = Instantiate(uruz);
            uruz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            uruz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            uruz2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject uruz3 = Instantiate(uruz);
            uruz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            uruz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            uruz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject uruz4 = Instantiate(uruz);
            uruz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            uruz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            uruz4.SetActive(true);
            rightIsIt4 = true;
        }
    }

    public void laguzF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            laguz.SetActive(true);
            rightIsIt1 = true;
        }
        else if (letterCount == 2)
        {
            GameObject laguz2 = Instantiate(laguz);
            laguz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            laguz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            laguz2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject laguz3 = Instantiate(laguz);
            laguz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            laguz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            laguz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject laguz4 = Instantiate(laguz);
            laguz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            laguz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            laguz4.SetActive(true);
        }
    }


    public void sowiloF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            sowilo.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject sowilo2 = Instantiate(sowilo);
            sowilo2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            sowilo2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject sowilo3 = Instantiate(sowilo);
            sowilo3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            sowilo3.SetActive(true);
            rightIsIt3 = true;
        }
        else if (letterCount == 4)
        {
            GameObject sowilo4 = Instantiate(sowilo);
            sowilo4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            sowilo4.SetActive(true);
        }
    }

    public void ingwazF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            ingwaz.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject ingwaz2 = Instantiate(ingwaz);
            ingwaz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ingwaz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            ingwaz2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject ingwaz3 = Instantiate(ingwaz);
            ingwaz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ingwaz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            ingwaz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject ingwaz4 = Instantiate(ingwaz);
            ingwaz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ingwaz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            ingwaz4.SetActive(true);
        }
    }

    public void othilaF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            othila.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject othila2 = Instantiate(othila);
            othila2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            othila2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            othila2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject othila3 = Instantiate(othila);
            othila3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            othila3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            othila3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject othila4 = Instantiate(othila);
            othila4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            othila4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            othila4.SetActive(true);
        }
    }

    public void perthroF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            perthro.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject perthro2 = Instantiate(perthro);
            perthro2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            perthro2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            perthro2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject perthro3 = Instantiate(perthro);
            perthro3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            perthro3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            perthro3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject perthro4 = Instantiate(perthro);
            perthro4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            perthro4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            perthro4.SetActive(true);
        }
    }

    public void raidhoF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            raidho.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject raidho2 = Instantiate(raidho);
            raidho2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            raidho2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject raidho3 = Instantiate(raidho);
            raidho3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            raidho3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject raidho4 = Instantiate(raidho);
            raidho4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            raidho4.SetActive(true);
        }
    }

    public void tiwazF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            tiwaz.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject tiwaz2 = Instantiate(tiwaz);
            tiwaz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            tiwaz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            tiwaz2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject tiwaz3 = Instantiate(tiwaz);
            tiwaz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            tiwaz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            tiwaz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject tiwaz4 = Instantiate(tiwaz);
            tiwaz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            tiwaz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            tiwaz4.SetActive(true);
        }
    }

    public void eihwazF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            eihwaz.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject eihwaz2 = Instantiate(eihwaz);
            eihwaz2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            eihwaz2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            eihwaz2.SetActive(true);
            rightIsIt2 = true;
        }
        else if (letterCount == 3)
        {
            GameObject eihwaz3 = Instantiate(eihwaz);
            eihwaz3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            eihwaz3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            eihwaz3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject eihwaz4 = Instantiate(eihwaz);
            eihwaz4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            eihwaz4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            eihwaz4.SetActive(true);
        }
    }

    public void jeraF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            jera.SetActive(true);
        }
        else if (letterCount == 2)
        {
            GameObject jera2 = Instantiate(jera);
            jera2.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            jera2.transform.position = new Vector3(Pos2.transform.position.x, Pos2.transform.position.y, 1);
            jera2.SetActive(true);
        }
        else if (letterCount == 3)
        {
            GameObject jera3 = Instantiate(jera);
            jera3.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            jera3.transform.position = new Vector3(Pos3.transform.position.x, Pos3.transform.position.y, 1);
            jera3.SetActive(true);
        }
        else if (letterCount == 4)
        {
            GameObject jera4 = Instantiate(jera);
            jera4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            jera4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            jera4.SetActive(true);
        }
    }

    
}
