using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using JetBrains.Annotations;

public class repair_button : MonoBehaviour
{
    public Image repair_station_img;
    public Sprite[] img = new Sprite[3];
    public Text text1;
    public Text text2;
    public bool isTestMode;
    public GameObject pop_up;
    public GameObject O_button;
    //public void repaired()
    //{
    //    Settings.complete_doll += repair_station.repair_doll;
    //    repair_station.repair_doll = 0;
    //}
    public void sell_now()
    {
        pop_up.SetActive(true);
        

        //Settings.coin += Settings.incomplete_doll;
        //Settings.incomplete_doll = 0;
    }

    public void advertise()
    {
        Debug.Log("ad");
        Settings.coin += 3 * Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
    }
    public void Upgrade()
    {
        pop_up.SetActive(true);
        //O_button.SendMessage("upgrade_popup");
        //if (repair_station.station_level == 1&&Settings.coin>=1000) {
        //    repair_station.station_level++;
        //    Settings.coin -= 1000;
        //}
        //if (repair_station.station_level == 2 && Settings.coin >= 1500)
        //{
        //    repair_station.station_level++;
        //    Settings.coin -= 1500;
        //}
    }
    // Start is called before the first frame update
    
    void Start()
    {
        pop_up.SetActive(false);
    }
   

   
    

// Update is called once per frame
void Update()
    {
        repair_station_img.sprite = img[repair_station.station_level];
    }



    
}
