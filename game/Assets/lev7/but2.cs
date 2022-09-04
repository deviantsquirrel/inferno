using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.CrossPlatformInput;

public class but2 : MonoBehaviour
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
    bool rightIsIt5 = false;
    bool rightIsIt6 = false;
    bool rightIsIt7 = false;

    public GameObject Pos2;
    public GameObject Pos3;
    public GameObject Pos4;
    public GameObject Pos5;
    public GameObject Pos6;
    public GameObject Pos7;


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
        if (CrossPlatformInputManager.GetButtonDown("clear"))
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
        if (rightIsIt1 && rightIsIt2 && rightIsIt3 && rightIsIt4 && rightIsIt5 && rightIsIt6)
        {
            scenrmann.colWork = 1;
            scenrmann.progres = 0;
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

        }
        else if (letterCount == 2)
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
            rightIsIt4 = true;
        }
        else if (letterCount == 5)
        {
            GameObject dagaz5 = Instantiate(dagaz);
            dagaz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            dagaz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            dagaz5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject dagaz6 = Instantiate(dagaz);
            dagaz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            dagaz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            dagaz6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject dagaz7 = Instantiate(dagaz);
            dagaz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            dagaz7.transform.position = new Vector3(1317, 391, 1);
            dagaz7.SetActive(true);
        }
    }

    public void isaF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            isa.SetActive(true);
            rightIsIt1 = true;
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
        else if (letterCount == 5)
        {
            GameObject isa5 = Instantiate(isa);
            isa5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            isa5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            isa5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject isa6 = Instantiate(isa);
            isa6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            isa6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            isa6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject isa7 = Instantiate(isa);
            isa7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            isa7.transform.position = new Vector3(1317, 391, 1);
            isa7.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject ansuz5 = Instantiate(ansuz);
            ansuz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ansuz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            ansuz5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject ansuz6 = Instantiate(ansuz);
            ansuz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ansuz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            ansuz6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject ansuz7 = Instantiate(ansuz);
            ansuz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ansuz7.transform.position = new Vector3(1317, 391, 1);
            ansuz7.SetActive(true);
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
            
        }
        else if (letterCount == 5)
        {
            GameObject uruz5 = Instantiate(uruz);
            uruz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            uruz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            uruz5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject uruz6 = Instantiate(uruz);
            uruz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            uruz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            uruz6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject uruz7 = Instantiate(uruz);
            uruz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            uruz7.transform.position = new Vector3(1317, 391, 1);
            uruz7.SetActive(true);

        }
    }

    public void laguzF()
    {
        letterCount++;
        if (letterCount == 1)
        {
            laguz.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject laguz5 = Instantiate(laguz);
            laguz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            laguz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            laguz5.SetActive(true);
            rightIsIt5 = true;
        }
        else if (letterCount == 6)
        {
            GameObject laguz6 = Instantiate(laguz);
            laguz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            laguz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            laguz6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject laguz7 = Instantiate(laguz);
            laguz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            laguz7.transform.position = new Vector3(1317, 391, 1);
            laguz7.SetActive(true);
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
        }
        else if (letterCount == 4)
        {
            GameObject sowilo4 = Instantiate(sowilo);
            sowilo4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            sowilo4.SetActive(true);
        }
        else if (letterCount == 5)
        {
            GameObject sowilo5 = Instantiate(sowilo);
            sowilo5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            sowilo5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject sowilo6 = Instantiate(sowilo);
            sowilo6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            sowilo6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject sowilo7 = Instantiate(sowilo);
            sowilo7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            sowilo7.transform.position = new Vector3(1317, 391, 1);
            sowilo7.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject ingwaz5 = Instantiate(ingwaz);
            ingwaz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ingwaz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            ingwaz5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject ingwaz6 = Instantiate(ingwaz);
            ingwaz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ingwaz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            ingwaz6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject ingwaz7 = Instantiate(ingwaz);
            ingwaz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            ingwaz7.transform.position = new Vector3(1317, 391, 1);
            ingwaz7.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject othila5 = Instantiate(othila);
            othila5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            othila5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            othila5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject othila6 = Instantiate(othila);
            othila6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            othila6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            othila6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject othila7 = Instantiate(othila);
            othila7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            othila7.transform.position = new Vector3(1317, 391, 1);
            othila7.SetActive(true);
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
            rightIsIt2 = true;
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
        else if (letterCount == 5)
        {
            GameObject perthro5 = Instantiate(perthro);
            perthro5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            perthro5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            perthro5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject perthro6 = Instantiate(perthro);
            perthro6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            perthro6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            perthro6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject perthro7 = Instantiate(perthro);
            perthro7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            perthro7.transform.position = new Vector3(1317, 391, 1);
            perthro7.SetActive(true);
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
            rightIsIt3 = true;

        }
        else if (letterCount == 4)
        {
            GameObject raidho4 = Instantiate(raidho);
            raidho4.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho4.transform.position = new Vector3(Pos4.transform.position.x, Pos4.transform.position.y, 1);
            raidho4.SetActive(true);
        }
        else if (letterCount == 5)
        {
            GameObject raidho5 = Instantiate(raidho);
            raidho5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            raidho5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject raidho6 = Instantiate(raidho);
            raidho6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            raidho6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject raidho7 = Instantiate(raidho);
            raidho7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            raidho7.transform.position = new Vector3(1317, 391, 1);
            raidho7.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject tiwaz5 = Instantiate(tiwaz);
            tiwaz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            tiwaz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            tiwaz5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject tiwaz6 = Instantiate(tiwaz);
            tiwaz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            tiwaz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            tiwaz6.SetActive(true);
            rightIsIt6 = true;
        }
        else if (letterCount == 7)
        {
            GameObject tiwaz7 = Instantiate(tiwaz);
            tiwaz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            tiwaz7.transform.position = new Vector3(1317, 391, 1);
            tiwaz7.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject eihwaz5 = Instantiate(eihwaz);
            eihwaz5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            eihwaz5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            eihwaz5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject eihwaz6 = Instantiate(eihwaz);
            eihwaz6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            eihwaz6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            eihwaz6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject eihwaz7 = Instantiate(eihwaz);
            eihwaz7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            eihwaz7.transform.position = new Vector3(1317, 391, 1);
            eihwaz7.SetActive(true);
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
        else if (letterCount == 5)
        {
            GameObject jera5 = Instantiate(jera);
            jera5.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            jera5.transform.position = new Vector3(Pos5.transform.position.x, Pos5.transform.position.y, 1);
            jera5.SetActive(true);
        }
        else if (letterCount == 6)
        {
            GameObject jera6 = Instantiate(jera);
            jera6.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            jera6.transform.position = new Vector3(Pos6.transform.position.x, Pos6.transform.position.y, 1);
            jera6.SetActive(true);
        }
        else if (letterCount == 7)
        {
            GameObject jera7 = Instantiate(jera);
            jera7.transform.SetParent(parent, false);
            //dagaz2.transform.parent = this.transform;
            jera7.transform.position = new Vector3(1317, 391, 1);
            jera7.SetActive(true);
        }
    }

   
}
