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

        //// �α��� ���� Ȯ��
        //if (social.localuser.authenticated)
        //{
        //    // ���� �÷��� ���� ������ ���� ui�� ȣ��
        //    playgamesplatform.instance.showachievementsui();
        //}
        //else
        //{
        //    // �α������� �ʾ��� ���� ó�� (��: �α��� â ǥ��)
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
