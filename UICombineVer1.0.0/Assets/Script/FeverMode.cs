using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeverMode : MonoBehaviour
{
    bool fever_on = false;
    public static int after_fever = 2;
    public static int i = 0;
    public int three_waves = 0;
    public int probab = 1;
    public bool dif_switch = true;
    float tpd;
    int score;
    int numm = 0;
    public GameObject FeverBackground;
    public GameObject Background;
    // Start is called before the first frame update
    void Start()
    {
        Background.SetActive(true);
        FeverBackground.SetActive(false); // 평상시 배경화면
    }

    // Update is called once per frame
    void Update()
    {
        for (; i < 1; i++)
        {
            probability();
        }
        if (probab == 0 && GetComponent<GenerateDots>().feverTimer > 10 && GetComponent<GenerateDots>().dot_count == 0) // 피버모드 전환
        {
            fever_on = true;
            dif_switch = false;
            GenerateDots.tpd = 1f; // 점생성 시간 빠르게
            GenerateDots.spw = 2f; // 점수 2점
            Background.SetActive(false);
            FeverBackground.SetActive(true); // 피버모드 배경화면 전환
            GetComponent<AudioSource>().Play(); // 브금 재생
            GetComponent<GenerateDots>().size = 3; // 점 개수 3개 
            GenerateDots.order = new GameObject[GetComponent<GenerateDots>().size];
            if (GetComponent<GenerateDots>().f)
            {
                three_waves++;
                GetComponent<GenerateDots>().f = false;
            }
        }

        if (three_waves == 4) // 피버모드 해제
        {
            GetComponent<AudioSource>().Stop(); // 브금 재생
            GenerateDots.tpd = 2f; // 점생성 시간 빠르게
            GenerateDots.spw = 1f; // 점수 2점
            Background.SetActive(true);
            FeverBackground.SetActive(false);
            GetComponent<GenerateDots>().feverTimer = 0;
            GenerateDots.order = new GameObject[GetComponent<GenerateDots>().size];
            three_waves = 0;
            dif_switch = true;
            fever_on = false;
            after_fever = 0;
        }

    }
    int probability() // 20%의 확률로 피버모드 활성화
    {
        if (Score.score > 3 && GetComponent<GenerateDots>().dot_count == 0 && !fever_on && after_fever != 1)
        {
            Debug.Log("피버 연산 가동");
            probab = Random.Range(1, 10) % 5;
        }

        return probab;
    }

}