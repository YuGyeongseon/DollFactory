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
    public GameObject inGameBackground;

    public AudioSource audioSource;
    public AudioClip buttonSound;
    public GameObject start_animation;


    private void main_move()
    {
        SceneManager.LoadScene("Game_Scene");
    }
    public void Play_button()
    {
        //Settings.vibrate();
        Handheld.Vibrate();

        inGameBackground.SetActive(true);
        background.SetActive(false);
        start_animation.SendMessage("start");

        Invoke("main_move", 0.58f);
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

    public void Custom_Button()
    {
        if(Settings.is_Sound)
        {
            audioSource.PlayOneShot(buttonSound);
        }
        SceneManager.LoadScene("shop__");
        audioSource.PlayOneShot(buttonSound);

    }


    // Start is called before the first frame update
    void Start()
    {
        background.SetActive(true);
        inGameBackground.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
