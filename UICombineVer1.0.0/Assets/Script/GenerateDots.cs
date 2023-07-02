using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



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
    GameObject dot1;
    GameObject dot2;
    GameObject dot3;
    public float timer = 0;
    public float feverTimer = 0;
    public float dif_timer = 0;
    public static float tpd = 2f; // 점 생성 시간 간격
    public static float spw = 1f; // 웨이브 당 제공점수
    public bool f = false; // FeverMode의 int three_waves 와 연동
    float max_x;
    float max_y;
    float min_x;
    float min_y;
    float random_x;
    float random_y;
    public bool wave = false;
    public bool GameOver = false;
    bool def = true;
    public int dot_count = 0; // 생성된 점의 개수
    public static int size;
    public static GameObject[] order;

    void Start()
    {
        pop_up.SetActive(false);

        timer = 0;
        dot_count = 0;
        size = 3;
        order = new GameObject[size];
        wave = false;
        GameOver = false;
        max_x = panel.GetComponent<SpriteRenderer>().bounds.max.x - 0.3f;
        max_y = panel.GetComponent<SpriteRenderer>().bounds.max.y - 0.3f;
        min_x = panel.GetComponent<SpriteRenderer>().bounds.min.x + 0.3f;
        min_y = panel.GetComponent<SpriteRenderer>().bounds.min.y + 0.3f;

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

            if (timer > tpd * size * 2)
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
                random_x = Random.Range(min_x, max_x);
                random_y = Random.Range(min_y, max_y);
                order[i] = Instantiate(dot);
                order[i].transform.position = new Vector2(random_x, random_y);
                wave = false;
            }
        }

        if (timer > tpd * order.Length + 1 && dot_count == order.Length)
        {
            foreach (GameObject i in order)
            {
                i.GetComponent<SpriteRenderer>().enabled = false;
            } // 점 모습 사라짐
            dot_count++;
        }

        if (feverTimer > 10 && Dot.touch_count >= 2)
        {
            f = true;
        }

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
            if (isScore <= 40)
            {
                notScore.notscore++;
                Settings.incomplete_doll++;
                indoll++;
            }
            else
            {
                Settings.complete_doll++;
                Score.score += spw;
                doll++;
            }
            timer = 0;
            dot_count = 0;
            Dot.touch_order = 0;
            Dot.touch_count = 0;
            FeverMode.i = 0;
            FeverMode.after_fever++;
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

}

