using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameover_button : MonoBehaviour
{

    public void retry()
    {
        SceneManager.LoadScene(7);
        auto_Save.Save();
    }

    public void home() 
    {
        SceneManager.LoadScene(0);
        auto_Save.Save();

    }

    public void achive()
    {

        //Debug.log("achive");
        //playgamesplatform.debuglogenabled = true;
        //playgamesplatform.activate();

        //// 로그인 상태 확인
        //if (social.localuser.authenticated)
        //{
        //    // 구글 플레이 게임 서비스의 업적 ui를 호출
        //    playgamesplatform.instance.showachievementsui();
        //}
        //else
        //{
        //    // 로그인하지 않았을 때의 처리 (예: 로그인 창 표시)
        //    debug.log("not logged in");
        //}
        auto_Save.Save();

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
