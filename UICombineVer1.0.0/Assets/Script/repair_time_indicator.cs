using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_time_indicator : MonoBehaviour
{
    private float hh;
    private float mm;
    private float ss;
    private string hh_str;
    private string mm_str;
    private string ss_str;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hh = 0;ss = 0;mm = 0;
        float Time = Settings.incomplete_doll * repair_station.speed[repair_station.station_level] - repair.timer;
        
        while (Time >= 3600)
        {
            hh++;
            Time -= 3600;
        }
        while(Time >= 60)
        {
            mm++;
            Time -= 60;
        }
        while (Time > 0)
        {
            ss++;
            Time--;
        }
        if(hh<10)
        {
            hh_str = "0" + hh;
        }
        else
        {
            hh_str = ""+hh;
        }
        if(mm < 10)
        {
            mm_str = "0" + mm;
        }
        else
        {
            mm_str = "" + mm;
        }
        if(ss<10)
        {
            ss_str = "0" + ss;
        }
        else
        {
            ss_str = "" + ss;
        }
        GetComponent<Text>().text = hh_str+" : "+mm_str+" : "+ss_str;
    }
}
