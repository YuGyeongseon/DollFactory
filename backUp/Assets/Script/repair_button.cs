using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using JetBrains.Annotations;

public class repair_button : MonoBehaviour
{
    public Image repair_station_img;
    public Sprite[] img = new Sprite[3];
    //public Text text1;
    //public Text text2;
    public bool isTestMode;
    public GameObject pop_up;
    public GameObject complete_pop_up;
    public GameObject O_button;
    //public void repaired()
    //{
    //    Settings.complete_doll += repair_station.repair_doll;
    //    repair_station.repair_doll = 0;
    //}
    public void sell_now()
    {
        PopUpSOund.playSound();

        Settings.isPopup = true;

        pop_up.SetActive(true);
        

        //Settings.coin += Settings.incomplete_doll;
        //Settings.incomplete_doll = 0;
    }

    public void advertise()
    {
        ClickSound.playSound();
        Debug.Log("ad");
        Settings.coin += 3 * Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
    }
    public void Upgrade()
    {
        PopUpSOund.playSound();

        
        
        //if (repair_station.station_level <= 2)
        if (Settings.stationLevel <= 1)
        {
                Settings.isPopup= true;
            pop_up.SetActive(true);
        }
        else
        {
            Settings.isPopup = true;

            complete_pop_up.SetActive(true);
        }
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
        complete_pop_up.SetActive(false);
    }
   

   
    

// Update is called once per frame
void Update()
    {
        //if (repair_station.station_level <= 2)
        if(Settings.stationLevel <= 1)
        {
            repair_station_img.sprite = img[Settings.stationLevel+1];
        }
    }



    
}
