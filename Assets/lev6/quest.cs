using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;


public class quest : MonoBehaviour
{
    public Text questa;
    public Text ans1;
    public Text ans2;
    public Text ans3;
    public Text ans4;
    string[] questi;
    string[] ans_1;
    string[] ans_2;
    string[] ans_3;
    string[] ans_4;
    int[] right;
    int raund=0;
    int wrNew = 1;
    int questaa = 0;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public int liz;

    public GameObject canvaEnd;
    //string[] questi;
    // Start is called before the first frame update
    void Start()
    {
        canvaEnd.SetActive(false);
        questi = new string[] { "Из чего Господь создал первого человека ?", "Как была сотворена жена Адама?", "Как звали жену Адама?",
            "Что по словам Господа случилось бы с людьми если бы они съели запретный плод?","Что сотворил Господь на седьмой день?",
            "Сколько лет было Иисусу на момент распятия?", "Кто принес ветку Ною?", "Кто из Апостолов трижды отрекся от Христа?",
        "Какой по счету идет заповедь «не убивай»?","За грех какого рода попадают на седьмой круг ада?","За грех какого рода попадают на восьмой круг ада?",
        "За грех какого рода не попадают на девятый круг ада?","Кого съел кит?","Слово дьявол означает:",
        "Какие города были разрушены Господом?","За что покарали жену Лота?","Благодаря чему Иосиф стал советником фараона?",
        "Как покарал Господь людей за строительство вавилонской башни?","За что покарал бог Каина?","Как покарал бог Каина?"};

        ans_1 = new string[] { "Прах земной", "Так же как и Адам","Ева",
            "Он не пояснял", "Человека",
            "42","Чайка","Иуда",
        "6","Воровство","Страстность",
        "Дезертирство","Иона","Карающий",
        "Содом и Гоморра","Она обернулась","Он спас жизнь фараона",
        "Он разделил единый язык на разные","Он не уважал отца","Не даровал ему жены"};

        ans_2 = new string[] { "Глина","Из ребра Адама","Ава",
            "Они бы заболели","Ничего",
            "18","Голубь","Матфей",
        "1","Суицид","Лицемерие" ,
        "Супружеская измена","Иосиф","Справедливый",
        "Садам и Гоморра","Она не смогла родить наследника","Его избрали путем голосования",
        "Он наслал чуму","Он не уважал бога","Сделал его рабом"};

        ans_3 = new string[] {"Ясень","Из другого животного","Мария",
            "Они бы обрели бессмертие","Животных",
            "33","Ворона","Петр",
        "8","Супружеская измена","Лень",
        "Предательство родителей","Лука","Огненный",
        "Садам и Гиммея","Она убила супруга","Он дал совет, как победить в войне",
        "Он уничтожил один из видов животных","Он убил своего брата","Превратил его в соляной столб"
        };
        ans_4 = new string[] { "Воздух","Из воды","Светлана",
            "Они бы умерли","Небо",
            "62","Воробей","Павел",
        "4","Дезертирство","Дезертирство",
        "Предательство покровителя","Матфей","Растекающийся",
        "Содом и Гиммея","У нее дрогнул голос","Он истолковал сны фараона",
        "Он превратил их в соляные столбы","Он убил отца","Сделал его вечным скитальцем земли"};

        right = new int[] { 1, 2, 1,4,2,3, 2,3,1,2,2,2,1,4,1,1,4, 1,3,4 };

    }

    void WriteNew(int raunda)
    {
        Random rnd = new Random();
        //int rr = state;
        int numa = Random.Range(0, 2);
        Debug.Log(numa);
        numa = numa + raund * 2;
        questa.text = questi[numa];
        ans1.text = ans_1[numa];
        ans2.text = ans_2[numa];
        ans3.text = ans_3[numa];
        ans4.text = ans_4[numa];
        questaa = numa;
        //raund++;
    }

    IEnumerator St1()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("lev7");
    }




    public void fBut()
    {
        if (right[questaa] == 1)
        {
            Debug.Log("True");
            raund++;
            wrNew = 1;
        } else
        {
            start.lives -= 1;
            Debug.Log("False");
            Drawagain();
        }
    }

    public void sBut()
    {
        if (right[questaa] == 2)
        {
            Debug.Log("True");
            raund++;
            wrNew = 1;
        }
        else
        {
            start.lives -= 1;
            Debug.Log("False");
            Drawagain();
        }
    }

    public void tBut()
    {
        if (right[questaa] == 3)
        {
            Debug.Log("True");
            raund++;
            wrNew = 1;
        }
        else
        {
            start.lives -= 1;
            Debug.Log("False");
            Drawagain();
        }
    }

    public void foBut()
    {
        if (right[questaa] == 4)
        {
            
            Debug.Log("True");
            raund++;
            wrNew = 1;
        }
        else
        {
            start.lives -= 1;
            Debug.Log("False");
            Drawagain();
        }
    }


    public void Drawagain()
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
        if (liz == 0)
        {
            SceneManager.LoadScene("menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("first"))
        {
            fBut();
        }
        if (CrossPlatformInputManager.GetButtonDown("second"))
        {
            sBut();
        }
        if (CrossPlatformInputManager.GetButtonDown("third"))
        {
            tBut();
        }
        if (CrossPlatformInputManager.GetButtonDown("fourth"))
        {
            foBut();
        }

        if (raund == 10)
        {
            canvaEnd.SetActive(true);
            StartCoroutine(St1());
        }
        if (wrNew == 1&& raund<10)
        {
            wrNew = 0;
            WriteNew(raund);
            
        }
        
        
    }
}
