using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class Main_Button : MonoBehaviour
{
    string log;
    public GameObject background;

    public GameObject start_animation;


    private void main_move()
    {
        SceneManager.LoadScene("Game_Scene");
    }
    public void Play_button()
    {
        //Settings.vibrate();
        Handheld.Vibrate();
        background.SetActive(false);
        start_animation.SendMessage("start");
        main_start_ani_con.Instantiate(start_animation);

        Invoke("main_move", 0.5f);

    }


    public void Setting_button()
    {
        SceneManager.LoadScene("Setting_Scene");
        
    }


    public void Shop_button()
    {
        SceneManager.LoadScene("Shop_Scene");
        Page_control.pagenum = 3;
        

    }

    public void Achive_button()
    {
        Debug.Log("ACHIVE");
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
      
        // 로그인 상태 확인
        if (Social.localUser.authenticated)
        {
            // 구글 플레이 게임 서비스의 업적 UI를 호출
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        else
        {
            // 로그인하지 않았을 때의 처리 (예: 로그인 창 표시)
            Debug.Log("Not logged in");
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        background.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
