using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_time_indicator : MonoBehaviour
{
    private float hh;
    private float mm;
    private float ss;
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
        
        GetComponent<Text>().text = hh+" : "+mm+" : "+ss;
    }
}
