using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeverMode : MonoBehaviour
{
    public static bool fever_on = false;
    public static int after_fever = 2;
    public static int i = 0;
    public static int three_waves = 0;
    static public int cycle;
    static public int a; // 인형당 피버모드 확률
    public int probab = 101;
    public bool dif_switch = true;
    public GameObject FeverBackground;
    public GameObject Background;
    // Start is called before the first frame update
    void Start()
    {
        Background.SetActive(true);
        FeverBackground.SetActive(false); // 평상시 배경화면
        //Debug.Log(a);
        //Debug.Log(cycle);
    }

    // Update is called once per frame
    void Update()
    {
        for (; i < 1; i++)
        {
            probability();
        }
        if (probab <= a && Score.score + notScore.notscore >= 3 && !fever_on) // 피버모드 전환
        {
            fever_on = true;
            dif_switch = false;
            GenerateDots.dotgenTime = 0.75f; // 점생성 시간 빠르게
            GenerateDots.doll_mul = 2;
            GenerateDots.indoll_mul = 3;
            Background.SetActive(false);
            FeverBackground.SetActive(true); // 피버모드 배경화면 전환
            // if(Settings.is_BGM)
            // {
            //     GetComponent<AudioSource>().Play(); // 브금 재생
            // }
            GenerateDots.size = 3; // 점 개수 3개 
            GenerateDots.order = new GameObject[GenerateDots.size];
            GenerateDots.vanish = 0.15f;
            GenerateDots.dotgenTime = GenerateDots.dotgenTime * 0.85f;
            // if (GetComponent<GenerateDots>().f)
            // {
            //     three_waves++;
            //     GetComponent<GenerateDots>().f = false;
            // }
            probab = 101;
            if (GenerateDots.timer <= 20)
                GenerateDots.dotgenTime = 1f;
            else if (GenerateDots.timer <= 40)
                GenerateDots.dotgenTime = 0.85f;
            else if (GenerateDots.timer <= 60)
                GenerateDots.dotgenTime = 0.6f;
            else if (GenerateDots.timer <= 80)
                GenerateDots.dotgenTime = 0.425f;
            else
                GenerateDots.dotgenTime = 0.38f;
            GetComponent<AudioSource>().pitch = 1.4f;
        }

        if (three_waves >= cycle && fever_on) // 피버모드 해제
        {
            GetComponent<AudioSource>().Stop();
            //GenerateDots.dotgenTime = 2f;
            GenerateDots.doll_mul = 1;
            GenerateDots.indoll_mul = 1;
            Background.SetActive(true);
            FeverBackground.SetActive(false);
            //GetComponent<GenerateDots>().feverTimer = 0;
            GenerateDots.order = new GameObject[GenerateDots.size];
            three_waves = 0;
            dif_switch = true;
            fever_on = false;
            after_fever = 0;
            GenerateDots.vanish = 0.25f;
            GetComponent<AudioSource>().pitch = 1f;
        }

    }
    int probability() // 20%의 확률로 피버모드 활성화
    {
        if (dollNum.doll_amount + notScore.notscore > 3 && GenerateDots.dot_count == 0 && !fever_on && after_fever != 1)
        {
            Debug.Log("피버연산 가동");
            probab = Random.Range(1, 101);
        }

        return probab;
    }

}