using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    //public static bool is_Sound = true;
    //public static bool is_Vib = true;
    //public static bool is_BGM = true;


   

    

    

    public static bool is_Sound;  //설정을 PlayerPrefs에서 부른 후 bool로 변환
    public static bool is_Vib;
    public static bool is_BGM;



    public void sound_button()
    {
        vibrate();

        if (!is_Sound)
        {
            GetComponent<AudioSource>().Play();
        }
        if (is_Sound) {
            is_Sound = false;
            Debug.Log("d");
            
        }
        else
        {
            is_Sound = true;
            
        }
        PlayerPrefs.SetInt("Sound",System.Convert.ToInt16(is_Sound));

    }

    public void BGM_button()
    {
        vibrate();
        if (is_Sound)
        {
            GetComponent<AudioSource>().Play();
        }
        if (is_BGM)
        {
            is_BGM = false;
            Debug.Log("b");
            
        }
        else
        {
            is_BGM = true;
            
        }
        PlayerPrefs.SetInt("BGM", System.Convert.ToInt16(is_BGM));

        
    }

    public void vib_button()
    {
        vibrate();
        if (is_Sound)
        {
            GetComponent<AudioSource>().Play();
        }
        if (is_Vib) {
            is_Vib = false;
            Debug.Log("v");
            
        }
        else
        {
            is_Vib = true;
            

        }
        PlayerPrefs.SetInt("Vib", System.Convert.ToInt16(is_Vib));
    }

    
    public static void vibrate()
    {
        if (is_Vib)
        {
            
            Handheld.Vibrate();
            
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        is_Sound = System.Convert.ToBoolean(PlayerPrefs.GetInt("Sound"));  //설정을 int로 변환후 PlayerPrefs에 저장 
        is_Vib = System.Convert.ToBoolean(PlayerPrefs.GetInt("Vib"));
        System.Convert.ToBoolean(PlayerPrefs.GetInt("BGM"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
