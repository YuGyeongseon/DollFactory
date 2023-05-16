using System.Collections;
using System.Collections.Generic;
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
    float max_x;
    float max_y;
    float min_x;
    float min_y;
    float random_x;
    float random_y;
    public bool wave = false;
    public bool GameOver = false;
    public int a = 0;
    public int[]order = new int[3];
    void Start()
    {
    timer = 0;
    a = 0;
    order[0] = 0;
    order[1] = 0;
    order[2] = 0;
    wave = false;
    GameOver = false;
    max_x = panel.GetComponent<SpriteRenderer>().bounds.max.x - 0.3f;
    max_y = panel.GetComponent<SpriteRenderer>().bounds.max.y - 0.3f;
    min_x = panel.GetComponent<SpriteRenderer>().bounds.min.x + 0.3f;
    min_y = panel.GetComponent<SpriteRenderer>().bounds.min.y + 0.3f;
        Dot.i = 0;
    }
    void Update()
    {
        if (GameOver == false)
        {
            dotGen(); // 점생성 함수
            if(dot1 != null && dot2 != null && dot3 != null)
            {
                touchDot(); // 점생성후 동작함수
            }
            //if (timer > 1.5)
            //{
            //    Debug.Log("Game Over!");
            //    GameOver = true;
            //} // 1.5초 경과후 게임오버
        }
    }

    void dotGen()
    {
        timer += Time.deltaTime;
        if (timer > 0.25 && a == 0)
        {
            wave = true;
            a++;
        }
        if (wave)
        {
            random_x = Random.Range(min_x, max_x );
            random_y = Random.Range(min_y, max_y);
            dot1 = Instantiate(dot);
            dot1.transform.position = new Vector2(random_x, random_y);
            dot1.GetComponent<Dot>().num = 1;
            wave = false;
        }    
        if (timer > 0.5 && a == 1)
        {
            wave = true;
            a++;
        }
        if (wave)
        {
            do
            {
                random_x = Random.Range(min_x, max_x );
                random_y = Random.Range(min_y, max_y);
            } 
            while(random_x == dot1.transform.position.x || random_y == dot1.transform.position.y);
            dot2 = Instantiate(dot);
            dot2.transform.position = new Vector2(random_x, random_y);
            dot2.GetComponent<Dot>().num = 2;
            wave = false;
        }     
        if (timer > 0.75 && a == 2)
        {
            wave = true;
            a++;
        }
        if (wave)
        {
            dot1.GetComponent<CircleCollider2D>();
            do
            {
                random_x = Random.Range(min_x, max_x );
                random_y = Random.Range(min_y, max_y);
            }while(random_x == dot1.transform.position.x || random_y == dot1.transform.position.y || random_x == dot2.transform.position.x || random_y == dot2.transform.position.y);
            dot3 = Instantiate(dot);
            dot3.transform.position = new Vector2(random_x, random_y);
            dot3.GetComponent<Dot>().num = 3;
            wave = false;
            timer = 0; //3번쨰 점 생성되고 바로 점모습없애면 3번째 점이 보일틈도 없이 빠르게 사라지기 때문에 timer를 0으로 한번 초기화 함.  
        }
        //if (timer > 0.75 && a == 3)
        //{
        //    dot1.GetComponent<SpriteRenderer>().enabled = false;
        //    dot2.GetComponent<SpriteRenderer>().enabled = false;
        //    dot3.GetComponent<SpriteRenderer>().enabled = false;
        //    a++;
        //} // 점 모습 사라짐
    }

    void touchDot()
    {
        if (dot1.GetComponent<Dot>().TouchDetector && dot2.GetComponent<Dot>().TouchDetector && dot3.GetComponent<Dot>().TouchDetector)
        {
            if(order[0] == 1 && order[1] == 2 && order[2] == 3)
            {
                    Score.previousScore = Score.score;
                    Score.score++;
                    Settings.coin++;
                    timer = 0;
                    a = 0;
                    Dot.i = 0;
                    Destroy(dot1);
                    Destroy(dot2);
                    Destroy(dot3); // 점이 순서에 맞게 터치 됐으면 점수 1점 추가
            }
            if(Dot.i > 2 && !(order[0] == 1 && order[1] == 2 && order[2] == 3))
            {
                GameOver = true;
                Debug.Log("Game Over!"); //클릭순서가 틀리면 게임오버
                SceneManager.LoadScene(0);
            }
       } 
    }
}
