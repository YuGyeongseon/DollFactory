using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class repair_button : MonoBehaviour
{
    public bool isTestMode;
    public void repaired()
    {
        Settings.complete_doll += repair_station.repair_doll;
        repair_station.repair_doll = 0;
    }
    public void sell_now()
    {
        Settings.coin += Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
    }

    public void advertise()
    {
        Debug.Log("ad");
        Settings.coin += 3 * Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
    }
    public void Upgrade()
    {
        if(repair_station.station_level == 1&&Settings.coin>=1000) {
            repair_station.station_level++;
            Settings.coin -= 1000;
        }
        if (repair_station.station_level == 2 && Settings.coin >= 1500)
        {
            repair_station.station_level++;
            Settings.coin -= 1500;
        }

    }
    // Start is called before the first frame update
    
    void Start()
    {
       
    }
   

   
    

// Update is called once per frame
void Update()
    {
    }



    
}
