using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GenerateDots : MonoBehaviour
{
    public GameObject pop_up;
    public Text comdoll;
    public Text incomdoll;
    public Text score_indicator;
    private int doll;
    private int indoll;


    public GameObject dot;
    public GameObject panel;
    static public float timer = 0;
    public float feverTimer = 0;
    public float dif_timer = 0;
    public static float tpd = 2f; // 점 생성 시간 간격
    public static float spw = 1; // 웨이브 당 제공점수
    public bool f = false; // FeverMode의 int three_waves 와 연동
    int defection;
    float max_x;
    float max_y;
    float min_x;
    float min_y;
    float random_x;
    float random_y;
    public bool wave = false;
    public bool GameOver = false;
    bool def = true;
    public static int dot_count = 0; // 생성된 점의 개수
    public static int size;
    public static GameObject[] order;
    List<float> xList;
    List<float> yList;
    void Start()
    {
        pop_up.SetActive(false);

        timer = 0;
        dot_count = 0;
        size = 3;
        order = new GameObject[size];
        xList = new List<float>();
        yList = new List<float>();
        wave = false;
        GameOver = false;
        max_x = panel.GetComponent<SpriteRenderer>().bounds.max.x - 0.5f;
        max_y = panel.GetComponent<SpriteRenderer>().bounds.max.y - 0.5f;
        min_x = panel.GetComponent<SpriteRenderer>().bounds.min.x + 0.5f;
        min_y = panel.GetComponent<SpriteRenderer>().bounds.min.y + 0.5f;
        defectRate();
        Debug.Log(defection);
        doll = 0;
        indoll = 0;

    }
    void Update()
    {

        if (GameOver == false)
        {
            if (GetComponent<FeverMode>().dif_switch)
            {
                difficulty();
            }
            timer += Time.deltaTime;
            feverTimer += Time.deltaTime;
            dif_timer += Time.deltaTime;
            dotGen(); // 점생성 함수
            if (Dot.touch_order == order.Length)
            {
                touchDot(); // 점생성후 동작함수
            }

            if (timer > tpd * order.Length+4)
            {
                gameOver();
            } // 제한시간 초과 게임오버
        }

    }

    void dotGen()
    {


        for (int i = 0; i < order.Length; i++)
        {
            if (timer > tpd * (i + 1) && dot_count == i)
            {
                wave = true;
                dot_count++;
            }

            if (wave)
            {
                //do
                //{
                random_x = Random.Range(min_x, max_x);
                random_y = Random.Range(min_y, max_y);
                //}while(checkOverlap(random_x,random_y));
                xList.Add(random_x);
                yList.Add(random_y);
                order[i] = Instantiate(dot);
                order[i].transform.position = new Vector2(random_x, random_y);
                wave = false;
            }

        }

        if (timer > tpd * order.Length + 1 && dot_count == order.Length)
        {
            foreach (GameObject i in order)
            {

                if (i.GetComponent<SpriteRenderer>().enabled)
                    i.GetComponent<SpriteRenderer>().enabled = false;
            } // 점 모습 사라짐
            dot_count++;
        }

        //if (feverTimer > 10 && Dot.touch_count >= 2)
        //{
        //    f = true;
        //}

    }

    void touchDot()
    {

        int count = 0;
        foreach (GameObject i in order)
        {
            if (i.GetComponent<Dot>().num != count)
            {
                def = false;
            }
            count++;
        }
        if (def)
        {
            int isScore = Random.Range(1, 101);
            if (isScore <= defection)
            {
                notScore.notscore++;
                Settings.incomplete_doll++;
                indoll++;
            }
            else
            {
                Score.score += spw;
                doll++;
            }
            if (FeverMode.fever_on)
            {
                FeverMode.three_waves++;
                Debug.Log(FeverMode.three_waves);
            }
            timer = 0;
            dot_count = 0;
            Dot.touch_order = 0;
            Dot.touch_count = 0;
            FeverMode.i = 0;
            FeverMode.after_fever++;
            xList.Clear();
            yList.Clear();
            foreach (GameObject i in order)
            {
                Destroy(i);
            }
        }

        if (!def)
        {
            gameOver();
        }


    }
    void gameOver() // 게임오버 
    {
        GameOver = true;
        Debug.Log("Game Over!");
        tpd = 2f;


        //SceneManager.LoadScene(7);
        size = 3;
        Score.score = 0;
        spw = 1;
        timer = 0;
        dot_count = 0;
        Dot.touch_order = 0;
        Dot.touch_count = 0;
        FeverMode.i = 0;
        xList.Clear();
        yList.Clear();
    
        comdoll.text = doll.ToString();
        incomdoll.text = indoll.ToString();
        score_indicator.text = Score.score.ToString();
        pop_up.SetActive(true);
    }
    void difficulty() // 점 개수 추가 
    {
        if (dif_timer >= 60 && dot_count == 0)
        {
            size = 7;
            order = new GameObject[size];
        }
        else if (dif_timer >= 45 && dot_count == 0)
        {
            size = 6;
            order = new GameObject[size];
        }
        else if (dif_timer >= 30 && dot_count == 0)
        {
            size = 5;
            order = new GameObject[size];
        }
        else if (dif_timer >= 15 && dot_count == 0)
        {
            size = 4;
            order = new GameObject[size];
        }
    }
    void getCoord() // 점 좌표 설정
    {
        do
        {
            random_x = Random.Range(min_x, max_x);
            random_y = Random.Range(min_y, max_y);
        } while (size == 1);
    }

    void thousand() // 1000점 이후 실행
    {
        if (Score.score >= 1000)
        {

        }
    }

    void defectRate() // 불량률
    {
        if (shopDoll.selectDollNum == 1)
        {
            defection = 50;
        }
        else if (shopDoll.selectDollNum == 2)
        {
            defection = 45;
        }
        else if (shopDoll.selectDollNum == 3)
        {
            defection = 30;
        }
        else if (shopDoll.selectDollNum == 4)
        {
            defection = 25;
        }
        else if (shopDoll.selectDollNum == 5)
        {
            defection = 20;
        }
        else if (shopDoll.selectDollNum == 6)
        {
            defection = 15;
        }
        else if (shopDoll.selectDollNum == 7)
        {
            defection = 10;
        }
        else if (shopDoll.selectDollNum == 8)
        {
            defection = 5;
        }
        else if (shopDoll.selectDollNum == 9)
        {
            defection = 3;
        }
    }

    bool checkOverlap(float x, float y) // 점 위치 중복 방지
    {
        int a = 0;
        foreach (float element in xList)
        {
            if (x <= element + 0.5 && x >= element - 0.5)
            {
                a++;
            }
        }

        foreach (float element in yList)
        {
            if (y <= element + 0.5 && x <= element - 0.5)
            {
                a++;
            }
        }

        if (a != 0)
            return true;
        else
            return false;
    }
}



    
