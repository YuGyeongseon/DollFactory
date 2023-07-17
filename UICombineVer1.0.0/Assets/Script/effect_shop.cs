using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class effect_shop : MonoBehaviour
{
    public bool test;
    public float count;


    public int target = 1;
    public static float effect_timer;

    public int[] effects = new int[9] { 1,2,3,4,5,6,7,8,9};

    public static int[] effect_list = new int[4];

    private float cnt = 0;
    private bool check;
    private DateTime dt;
    // Start is called before the first frame update
    
    private void pick_list()
    {
        for (int i = 0; i < 4; i++)
        {

            int ch = 1;
            while (ch != 0)
            {
                ch = 0;
                effect_list[i] = effects[ UnityEngine.Random.Range(0,9)];
                for (int j = 0; j < i; j++)
                {
                    if (effect_list[i] == effect_list[j] || Settings.is_effect[effect_list[i]])
                    {
                        ch += 1;
                    }
                }
            }
            Debug.Log(effect_list[i]);

        }
    }
    
    
    void Start()
    {
        effect_timer = 0;
        pick_list();
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
