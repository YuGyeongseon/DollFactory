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
    public static bool isSetting;
    string log;
    public GameObject background;
    public GameObject inGameBackground;

    public AudioSource audioSource;
    public AudioClip buttonSound;
    public GameObject start_animation;

    public GameObject indicaters;
    private void main_move()
    {
        SceneManager.LoadScene("Game_Scene");
    }
    public void Play_button()
    {
        shopDoll.selectDollNum = PlayerPrefs.GetInt("selected");
        //Settings.vibrate();
        if(Settings.is_Vib)
        {
            Handheld.Vibrate();
        }
        ClickSound.playSound();

        inGameBackground.SetActive(true);
        indicaters.SetActive(false);
        background.SetActive(false);
        start_animation.SendMessage("start");
        Page_control.pagenum = 7;

        Invoke("main_move", 0.58f);
    }


    public void Setting_button()
    {
        ClickSound.playSound();

        SceneManager.LoadScene("Setting_Scene");
        isSetting = true;
        
    }


    public void Shop_button()
    {
        ClickSound.playSound();

        SceneManager.LoadScene("Shop_Scene");
        Page_control.pagenum = 3;
        

    }

    public void Achive_button()
    {
        Debug.Log("ACHIVE");
        ClickSound.playSound();

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
        ClickSound.playSound();
        Page_control.pagenum = 5;
        SceneManager.LoadScene("shop__");
        //if(Settings.is_Sound)
        //{
        //    audioSource.PlayOneShot(buttonSound);
        //}

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
