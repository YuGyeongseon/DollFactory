using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameover_button : MonoBehaviour
{

    public void retry()
    {
        SceneManager.LoadScene(7);
    }

    public void home() 
    {
        SceneManager.LoadScene(0);
    }

    public void achive()
    {
        /*
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
        */
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
