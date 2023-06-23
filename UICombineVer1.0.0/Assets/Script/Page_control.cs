using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Page_control : MonoBehaviour
{
    public static int pagenum;
    // Start is called before the first frame update
    void Start()
    {
    }


        public static void page()
        {
            SceneManager.LoadScene(pagenum);
        }

        public void move1()
        {
            SceneManager.LoadScene("doll_Sell");
            pagenum = 1;
        }

        public void move2()
        {
            SceneManager.LoadScene("Main_Scene");
            pagenum = 0;
        }

        public void move3()
        {
            SceneManager.LoadScene("factory");
            pagenum = 2;
        }

    public void move4()
    {
        SceneManager.LoadScene("Shop_Scene");
        pagenum = 3;
    }

    public void move5()
    {
        SceneManager.LoadScene("effect_scene");
        pagenum = 4;
    }

    public void move6()
    {
        SceneManager.LoadScene("shop__");
        pagenum = 5;
    }

    // Update is called once per frame
    void Update()
        {

        }
    }

