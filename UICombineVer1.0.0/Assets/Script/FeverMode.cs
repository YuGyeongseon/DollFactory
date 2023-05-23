using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeverMode : MonoBehaviour
{
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
       
        if ((GetComponent<GenerateDots>().feverTimer > 10  && GetComponent<GenerateDots>().a == 0)|| Score.score > 30)
        {
            GetComponent<AudioSource>().Play(); // 브금 재생
            //SceneManager.LoadScene("FeverBackground");
            GenerateDots.tpd = 1f; // 점생성 시간 빠르게
            Debug.Log("FEVER MODE");
            Background.SetActive(false);
            FeverBackground.SetActive(true); // 피버모드 배경화면 전환
        }
    }
}
