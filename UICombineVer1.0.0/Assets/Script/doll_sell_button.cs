using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//using UnityEditor.AddressableAssets;
using UnityEngine;

public class doll_sell_button : MonoBehaviour
{
    public AudioSource audioSource;
    public static bool sell2 = false;
    public AudioClip audioClip;
    public void sell_button1()
    {
        
        if (Settings.complete_doll >= 1)
        {
            Settings.complete_doll -= 1;
            Settings.coin += 2;
        }

    }



    public void sell_button2()
    {
        if (sell2)
        {
            if (Settings.complete_doll >= 1)
            {
                Settings.complete_doll -= 1;
                Settings.coin += 3;
            }

        }
        else
        {
            if(Settings.incomplete_doll >= 5)
            {
                Settings.incomplete_doll -= 5;
                sell2 = true;
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void but1()
    {
        Settings.complete_doll+=100;
        Settings.incomplete_doll += 100;
        Settings.coin+=100;
        Settings.bear_doll += 100;


    }
    public void but2()
    {
        Settings.complete_doll = 0;
        Settings.incomplete_doll = 0;
        Settings.coin = 0;
        Settings.bear_doll = 0;
        Settings.stationLevel= 0;

        for (int i = 2; i <= 9; i++)
        {
            Settings.dollOwned[i] = false;

        }
        for (int i = 0; i <= 11; i++)
        {
            Settings.effect_owned[i] = false;
        }
        auto_Save.Save();


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
