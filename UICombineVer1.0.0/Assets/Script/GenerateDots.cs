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
    public Text beardoll;
    public Text score_indicator;
    private int doll;
    private int indoll;
    private int score;
    private int bear;
    public GameObject dot;
    public GameObject panel;

    static public float cycle_timer = 0; // 사이클마다 초기화
    public static float timer = 0; // 플레이 경과시간
    static public float vanish = 0.25f; // 점 사라지는 시간
    [SerializeField] public static float dotgenTime; // 점 생성 소요시간
    public static int spw; // 웨이브 당 제공점수
    public bool f = false; // FeverMode의 int three_waves 와 연동
    int defection, bearRate;
    [SerializeField] int probab, probab3, probab4, probab5, probab6, probab7;
    float max_x;
    float max_y;
    float min_x;
    float min_y;
    float random_x;
    float random_y;
    public bool wave = false;
    public bool GameOver = false;
    bool def = true;
    public static int dot_count; // 생성된 점의 개수
    public static int size;
    public static GameObject[] order;
    List<float> xList;
    List<float> yList;
    int delayNum;
    public AudioSource audioSource;
    public AudioClip gameOverBgm;
    void Start()
    {
        SpriteRenderer spriteRenderer = panel.gameObject.GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            return;
        float _width = spriteRenderer.bounds.size.x;
        float _height = spriteRenderer.bounds.size.y;
        float worldScreenHeight = (float)(Camera.main.orthographicSize * 2.0);
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
        gameObject.transform.localScale = new Vector3(worldScreenWidth / _width, worldScreenHeight / _height, 1);
        probab = Random.Range(1, 101);
        pop_up.SetActive(false);
        cycle_timer = 0;
        if(Settings.is_BGM)
        {
            audioSource.Play();

        }
        dot_count = 0;
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
        doll = 0;
        indoll = 0;
        spw = 1;
        Dot.touch_order = 0;
        Dot.touch_count = 0;
        FeverMode.fever_on = false;
        FeverMode.after_fever = 0;
        Invoke("delay", 1f);
        BGM.Bgm.GetComponent<AudioSource>().Pause();
        if(Settings.is_BGM)
        {
            //GetComponent<AudioSource>().Play();
        }
    }
    void delay()
    {
        delayNum = 1;
    }
    void Update()
    {

        if (GameOver == false&& delayNum == 1)
        {
            if (GetComponent<FeverMode>().dif_switch)
            {
                difficulty();
            }
            cycle_timer += Time.deltaTime;
            timer += Time.deltaTime;
            //feverTimer += Time.deltaTime;
            if (dot_count < size + 1)
            {
                dotGen(); // 점생성 함수
            }
            if (Dot.touch_order == order.Length)
            {
                touchDot(); // 점생성후 동작함수
            }
            //if (FeverMode.fever_on)
            //{
            //    audioSource.pitch = 1.4f;
            //}
            //if (FeverMode.fever_on)
            //{
            //    audioSource.pitch = 1.0f;
            //}
            if (cycle_timer > (dotgenTime * 2) + vanish)
            {
                gameOver();
            } // 제한시간 초과 게임오버
        }

    }

    void dotGen()
    {


        for (int i = 0; i < order.Length; i++)
        {
            if (cycle_timer > dotgenTime / order.Length * i && dot_count == i)
            {
                wave = true;
                dot_count++;
            }

            if (wave)
            {
                do
                {
                    random_x = Random.Range(min_x, max_x);
                    random_y = Random.Range(min_y, max_y);
                }while(checkOverlap(random_x, random_y)); //do-while부분
                xList.Add(random_x);
                yList.Add(random_y);
                order[i] = Instantiate(dot);
                dotCreateSound.playSound();
                order[i].transform.position = new Vector2(random_x, random_y);
                wave = false;
            }

        }
        if (cycle_timer >= dotgenTime + vanish)
        {
            Debug.Log("사라짐");
            foreach (GameObject i in order)
            {
                Debug.Log("사라짐");
                if (i.GetComponent<SpriteRenderer>().enabled)
                {
                    Debug.Log("사라짐");
                    i.GetComponent<SpriteRenderer>().enabled = false;
                }
            } // 점 모습 사라짐
            Debug.Log("사라짐");
            dot_count++;

            //gameObject.GetComponent<AudioSource>().Play();

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
        { // 인게임 점수 계산 추가 해야됨
            int isScore = Random.Range(1, 101);
            if (isScore <= defection)
            {
                notScore.notscore++;
                Score.score++;
                score++;
                indoll++;
            }
            else
            {
                dollNum.doll_amount++;
                Score.score += spw;
                score += spw;
                doll++;
                Settings.coin += spw;
            }
            if (isScore <= bearRate)
            {
                Settings.bear_doll++;
                bear++;
                particle_controller.changeColorYellow();
            }
            if (FeverMode.fever_on)
            {
                FeverMode.three_waves++;
                Debug.Log(FeverMode.three_waves);
            }
            cycle_timer = 0;
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
            probab = Random.Range(1, 101);

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
        audioSource.Stop();

        //SceneManager.LoadScene(7);
        size = 3;
        Score.score = 0;
        spw = 1;
        cycle_timer = 0;
        dot_count = 0;
        Dot.touch_order = 0;
        Dot.touch_count = 0;
        FeverMode.i = 0;
        xList.Clear();
        yList.Clear();
        Settings.incomplete_doll+=indoll;

        comdoll.text = doll.ToString() + "개";
        incomdoll.text = indoll.ToString() + "개";
        score_indicator.text = score.ToString();
        beardoll.text = bear.ToString()+"개";
        if(Settings.is_BGM)
        {
            audioSource.PlayOneShot(gameOverBgm);
        }
        pop_up.SetActive(true);
        if(Settings.is_Vib)
        {
            Vibration.Vibrate(500);

        }

        GetComponent<AudioSource>().Stop();
    }
    void difficulty() //  시간 경과 할 수록 각종 수치 변경 
    {
        if (timer <=20)
        {
            probab3 = 75;
            probab4 = 95;
            probab5 = 100;
            probab6 = -1;
            probab7 = -1;
            Debug.Log("시작");
        }
        else if (timer <= 40)
        {
            probab3 = 55;
            probab4 = 80;
            probab5 = 95;
            probab6 = 100;
            probab7 = -1;
            Debug.Log("20초 경과");
        }
        else if (timer <= 60)
        {
            probab3 = 30;
            probab4 = 60;
            probab5 = 90;
            probab6 = 100;
            probab7 = -1;
            Debug.Log("40초 경과");
        }
        else if (timer <= 80)
        {
            probab3 = 20;
            probab4 = 40;
            probab5 = 60;
            probab6 = 80;
            probab7 = 100;
            Debug.Log("60초 경과");
        }
        else
        {
            probab3 = 10;
            probab4 = 20;
            probab5 = 50;
            probab6 = 80;
            probab7 = 100;
            Debug.Log("80초 경과");
        }

        if (probab <= probab3 && dot_count == 0)
        {
            size = 3;
            order = new GameObject[size];
            if (timer <= 20)
                dotgenTime = 1.25f;
            else if (timer <= 40)
                dotgenTime = 1f;
            else if (timer <= 60)
                dotgenTime = 0.75f;
            else if (timer <= 80)
                dotgenTime = 0.5f;
            else
                dotgenTime = 0.45f;
        }
        else if (probab <= probab4 && dot_count == 0)
        {
            size = 4;
            order = new GameObject[size];
            if (timer <= 20)
                dotgenTime = 1.5f;
            else if (timer <= 40)
                dotgenTime = 1.25f;
            else if (timer <= 60)
                dotgenTime = 1f;
            else if (timer <= 80)
                dotgenTime = 0.75f;
            else
                dotgenTime = 0.6f;
        }
        else if (probab <= probab5 && dot_count == 0)
        {
            size = 5;
            order = new GameObject[size];
            if (timer <= 20)
                dotgenTime = 1.75f;
            else if (timer <= 40)
                dotgenTime = 1.5f;
            else if (timer <= 60)
                dotgenTime = 1.25f;
            else if (timer <= 80)
                dotgenTime = 0.85f;
            else
                dotgenTime = 0.7f;
        }
        else if (probab <= probab6 && dot_count == 0)
        {
            size = 6;
            order = new GameObject[size];
            if (timer <= 40)
                dotgenTime = 1.65f;
            else if (timer <= 60)
                dotgenTime = 1.35f;
            else if (timer <= 80)
                dotgenTime = 0.95f;
            else
                dotgenTime = 0.75f;
        }
        else if (probab <= probab7 && dot_count == 0)
        {
            size = 7;
            order = new GameObject[size];
            if (timer <= 80)
                dotgenTime = 1f;
            else
                dotgenTime = 0.85f;
        }
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
            bearRate = 1;//원래 1임
            FeverMode.a = 0;
            FeverMode.cycle= 0;
        }
        else if (shopDoll.selectDollNum == 2)
        {
            defection = 45;
            bearRate = 3;
            FeverMode.a = 5;
            FeverMode.cycle = 3;
        }
        else if (shopDoll.selectDollNum == 3)
        {
            defection = 30;
            bearRate = 5;
            FeverMode.a = 5;
            FeverMode.cycle = 3;
        }
        else if (shopDoll.selectDollNum == 4)
        {
            defection = 25;
            bearRate = 7;
            FeverMode.a = 10;
            FeverMode.cycle = 3;
        }
        else if (shopDoll.selectDollNum == 5)
        {
            defection = 20;
            bearRate = 10;
            FeverMode.a = 15;
            FeverMode.cycle = 5;
        }
        else if (shopDoll.selectDollNum == 6)
        {
            defection = 15;
            bearRate = 12;
            FeverMode.a = 20;
            FeverMode.cycle = 5;
        }
        else if (shopDoll.selectDollNum == 7)
        {
            defection = 10;
            bearRate = 15;
            FeverMode.a = 25;
            FeverMode.cycle = 5;
        }
        else if (shopDoll.selectDollNum == 8)
        {
            defection = 5;
            bearRate = 18;
            FeverMode.a = 30;
            FeverMode.cycle = 7;
        }
        else if (shopDoll.selectDollNum == 9)
        {
            defection = 3;
            bearRate = 20;
            FeverMode.a = 35;
            FeverMode.cycle = 7;
        }
    }

    bool checkOverlap(float x, float y) // 점 위치 중복 방지
    {
        bool a = false;
        for (int i = 0; i < dot_count - 1; i++)
        {
            if (x >= xList[i] - 0.3 && x <= xList[i] + 0.3)
                if (y >= yList[i] - 0.3 && y <= yList[i] + 0.3)
                    a = true;
        }

        if (a)
            return true;
        else
            return false;
    }
}



    
