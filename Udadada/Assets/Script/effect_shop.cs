using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class effect_shop : MonoBehaviour
{
    public bool test;
    public float count;


    public int target = 1;
    public static float effect_timer;

    public int[] effects;

    public static int[] effect_list = new int[4];

    private float cnt = 0;
    private bool check;
    private DateTime dt;
    // Start is called before the first frame update
    
    private void pick_list()
    {
        Debug.Log(effects.Length);
        foreach(int i in effects)
        {
            Debug.Log(effects[i])
;       }
        Debug.Log(effects[8]);
        Debug.Log(effects[9]);
        effect_list[1] = effects[UnityEngine.Random.Range(0,12)];
        Debug.Log(effect_list[1]+"¹Ù²ñ");

        PlayerPrefs.SetInt("effect", effect_list[1]);
        PlayerPrefs.SetInt("effect_day", dt.Day);
    }
    
    
    void Start()
    {
        effects = new int[12] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11 };
        effect_timer = 0;
        if (!test)
        {
            if (PlayerPrefs.GetInt("effect_day") != dt.Day)
            {
                Debug.Log("pick_list");
                pick_list();
                
            }
            else
            {
                Debug.Log("pick_X");
                effect_list[1] = PlayerPrefs.GetInt("effect");
            }

        }
        else
        {
            pick_list();
        }

        var obj = FindObjectsOfType<effect_shop>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        dt = DateTime.Now;

        /*
        cnt += Time.deltaTime;
        effect_timer = count - cnt;
        if(cnt>=count)
        {
            pick_list();
            cnt = 0;
        }
        */

        
        //Debug.Log(dt.TimeOfDay.Hours);

        if (test)
        {
            
            if (dt.Second % 20 == 0)
            {
                if (check)
                {
                    pick_list();
                }
                check = false;
            }
            else
            {
                check = true;
            }
        }
        else
        {
            
            
            if (dt.TimeOfDay.Hours == target)
            {
                if (check)
                {
                    pick_list();
                }
                check = false;
            }
            else
            {
                check = true;
            }
        }
    }
}
