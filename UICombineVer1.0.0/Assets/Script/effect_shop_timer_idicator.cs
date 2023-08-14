using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effect_shop_timer_idicator : MonoBehaviour
{
    private int hh;
    private int mm;
    private int ss;
    private string hh_str;
    private string mm_str;
    private string ss_str;

    private DateTime tt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        hh = 0; ss = 0; mm = 0;
        float Time = effect_shop.effect_timer;

        while (Time >= 3600)
        {
            hh++;
            Time -= 3600;
        }
        while (Time >= 60)
        {
            mm++;
            Time -= 60;
        }
        while (Time > 0)
        {
            ss++;
            Time--;
        }

        GetComponent<Text>().text = hh + " : " + mm + " : " + ss;
        */

        

        DateTime dt = DateTime.Now;

        DateTime tt = DateTime.Today.AddDays(1);

        

        hh = (tt - dt).Hours;
        mm=(tt-dt).Minutes; ss=(tt-dt).Seconds;

        if (hh < 10)
        {
            hh_str = "0" + hh;
        }
        else
        {
            hh_str = "" + hh;
        }
        if (mm < 10)
        {
            mm_str = "0" + mm;
        }
        else
        {
            mm_str = "" + mm;
        }
        if (ss < 10)
        {
            ss_str = "0" + ss;
        }
        else
        {
            ss_str = "" + ss;
        }
        GetComponent<Text>().text = hh_str + " : " + mm_str + " : " + ss_str;
    }
}

