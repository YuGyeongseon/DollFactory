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
      
        // �α��� ���� Ȯ��
        if (Social.localUser.authenticated)
        {
            // ���� �÷��� ���� ������ ���� UI�� ȣ��
            PlayGamesPlatform.Instance.ShowAchievementsUI();
        }
        else
        {
            // �α������� �ʾ��� ���� ó�� (��: �α��� â ǥ��)
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
