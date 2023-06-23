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
    public void Play_button()
    {
        //Settings.vibrate();
        Handheld.Vibrate();
        SceneManager.LoadScene("Game_Scene");
        
        
    }


    public void Setting_button()
    {
        SceneManager.LoadScene("Setting_Scene");
        
    }


    public void Shop_button()
    {
        SceneManager.LoadScene("Shop_Scene");
        

    }

    public void Achive_button()
    {
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
