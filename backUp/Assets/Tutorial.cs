using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{

    public static int tuto_page;
    public GameObject dot1;
    public GameObject dot2;
    public GameObject dot3;

    public GameObject dt1;
    public GameObject dt2;
    public GameObject dt3;

    public GameObject button;

    public GameObject back;


    public Text guide;
    public Text button_text;

    private void dot_1()
    {
        dot1.SetActive(true);
    }
    private void dot_2()
    {
        dot2.SetActive(true);
    }
    private void dot_3()
    {
        dot3.SetActive(true);
    }
    private void button_appear()
    {
        button.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        dt1.SetActive(false); dt2.SetActive(false); dt3.SetActive(false);
        dot1.SetActive(false);
        dot2.SetActive(false);
        dot3.SetActive(false);
        button.SetActive(false);
        guide.text = "점이 무작위 위치에 등장합니다.\n" +
            "이 점들의 위치를 기억하세요!";

        Invoke("dot_1", 0.5f);
        Invoke("dot_2", 1.0f);
        Invoke("dot_3", 1.5f);
        tuto_page = 1;
        button_text.text = "Next";
        Invoke("button_appear", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void dt_1()
    {
        dt1.SetActive(true);
    }

    private void dt_2()
    {
        dt2.SetActive(true);
    }

    private void dt_3()
    {
        dt3.SetActive(true);
    }

    private void back_appear()
    {
        back.SetActive(true);
    }

    public void tutorial2()
    {
        back.SetActive(false);
        guide.text = "";

        Debug.Log("ss");
        dot1.SetActive(false);
        dot2.SetActive(false);  
        dot3.SetActive(false);

        Invoke("dt_1", 0.5f);
        Invoke("dt_2", 1.0f);
        Invoke("dt_3", 1.5f);
        Invoke("back_appear", 2.0f);

        tuto_page++;

        guide.text = "점이 사라진 이후,\n제한 시간안에 점의 위치를 순서대로 누르면 됩니다!";
        button_text.text = "Play!";

        PlayerPrefs.SetInt("tutorial", 1);

    }
}
