using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GenerateDots : MonoBehaviour
{
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
    public int size;
    public static GameObject[] order;

    void Start()
    {
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

    }
    void Update()
    {
        //Debug.Log(tpd);
        //if (GameOver == false)
        //{
        //    feverTimer += Time.deltaTime;
        //    dotGen(); // 점생성 함수

        //    if (dot1 != null && dot2 != null && dot3 != null)
        //    {
        //        touchDot(); // 점생성후 동작함수
        //    }
        //    if (timer > tpd * 3)
        //    {
        //        Debug.Log("Game Over!");
        //        GameOver = true;
        //        SceneManager.LoadScene(0);
        //    } // 1.5초 경과후 게임오버
        //}
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
        //timer += Time.deltaTime;
        //if (timer > tpd && a == 0)
        //{
        //    wave = true;
        //    a++;
        //}
        //if (wave)
        //{
        //    random_x = Random.Range(min_x, max_x );
        //    random_y = Random.Range(min_y, max_y);
        //    dot1 = Instantiate(dot);




        //    dot1.transform.position = new Vector2(random_x, random_y);
        //    dot1.GetComponent<Dot>().num = 1;
        //    wave = false;
        //}    
        //if (timer > tpd*2 && a == 1)
        //{
        //    wave = true;
        //    a++;
        //}
        //if (wave)
        //{
        //    do
        //    {
        //        random_x = Random.Range(min_x, max_x );
        //        random_y = Random.Range(min_y, max_y);
        //    } 
        //    while(random_x == dot1.transform.position.x || random_y == dot1.transform.position.y);
        //    dot2 = Instantiate(dot);
        //    dot2.transform.position = new Vector2(random_x, random_y);
        //    dot2.GetComponent<Dot>().num = 2;
        //    wave = false;
        //}     
        //if (timer > tpd*3 && a == 2) 
        //{
        //    wave = true;
        //    a++;
        //}
        //if (wave)
        //{
        //    dot1.GetComponent<CircleCollider2D>();
        //    do
        //    {
        //        random_x = Random.Range(min_x, max_x );
        //        random_y = Random.Range(min_y, max_y);
        //    }while(random_x == dot1.transform.position.x || random_y == dot1.transform.position.y || random_x == dot2.transform.position.x || random_y == dot2.transform.position.y);
        //    dot3 = Instantiate(dot);
        //    dot3.transform.position = new Vector2(random_x, random_y);
        //    dot3.GetComponent<Dot>().num = 3;
        //    wave = false;
        //    timer = 0; //3번쨰 점 생성되고 바로 점모습없애면 3번째 점이 보일틈도 없이 빠르게 사라지기 때문에 timer를 0으로 한번 초기화 함.  
        //}
        //if (timer > 1 && a == 3)//0.75
        //{
        //    dot1.GetComponent<SpriteRenderer>().enabled = false;
        //    dot2.GetComponent<SpriteRenderer>().enabled = false;
        //    dot3.GetComponent<SpriteRenderer>().enabled = false;
        //    a++;
        //} // 점 모습 사라짐

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
        //if (dot1.GetComponent<Dot>().TouchDetector && dot2.GetComponent<Dot>().TouchDetector && dot3.GetComponent<Dot>().TouchDetector)
        //{
        //    if(order[0] == 1 && order[1] == 2 && order[2] == 3)
        //    {
        //        int isScore = Random.Range(1, 101);
        //        if (isScore <= 40)
        //        {
        //            notScore.notscore++;
        //        }
        //        else
        //        {

        //            Score.score++;
        //        }
        //            Settings.coin++;
        //            timer = 0;
        //            a = 0;
        //            Dot.i = 0;
        //            Destroy(dot1);
        //            Destroy(dot2);
        //            Destroy(dot3); // 점이 순서에 맞게 터치 됐으면 점수 1점 추가
        //            order[0] = 0;
        //            order[1] = 0;
        //            order[2] = 0;
        //    }
        //    if(Dot.i > 2 && !(order[0] == 1 && order[1] == 2 && order[2] == 3))
        //    {
        //        GameOver = true;
        //        Debug.Log("Game Over!"); //클릭순서가 틀리면 게임오버
        //        SceneManager.LoadScene(0);
        //    }
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
            }
            else
            {

                Score.score+= spw;
            }
            //Settings.coin++;
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
        SceneManager.LoadScene(0);
        size = 3;
        Score.score = 0;
        spw = 1;
        timer = 0;
        dot_count = 0;
        Dot.touch_order = 0;
        Dot.touch_count = 0;
        FeverMode.i = 0;
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

