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


   

    internal static int coin;

    

    public static bool is_Sound;  //설정을 PlayerPrefs에서 부른 후 bool로 변환
    public static bool is_Vib;
    public static bool is_BGM;
    public static int presentDoll;
    public static int[] price = new int[10];
    internal static int complete_doll;
    internal static int incomplete_doll;
    internal static int bear_doll;


    public static bool[] effect_owned = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
    public static bool[] dollOwned = new bool[10] { true, true, false, false, false, false, false, false, false ,false};
    public static bool[] is_effect = new bool[10] { false, false, false, false, false, false, false, false,false,false };

    public static int effect_selected;
    public void sound_button()
    {
        vibrate();
        ClickSound.playSound();

        
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
        ClickSound.playSound();
        if (is_BGM)
        {
            is_BGM = false;
            BGM.x = 1;
            Debug.Log("False");
            
        }
        else
        {
            is_BGM = true;
            
        }
        PlayerPrefs.SetInt("BGM", System.Convert.ToInt16(is_BGM));

        
    }

    public void vib_button()
    {
        ClickSound.playSound();

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


        price[1] = 1;
        price[2] = 2;
        price[3] = 3;
        price[4] = 4;
        price[5] = 5;
        price[6] = 6;
        price[7] = 7;
        price[8] = 8;
        price[9] = 9;

        

        is_Sound = System.Convert.ToBoolean(PlayerPrefs.GetInt("Sound"));  //설정을 int로 변환후 PlayerPrefs에 저장 
        is_Vib = System.Convert.ToBoolean(PlayerPrefs.GetInt("Vib"));
        System.Convert.ToBoolean(PlayerPrefs.GetInt("BGM"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
