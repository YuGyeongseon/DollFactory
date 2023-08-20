using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class upgrade_pop_up : MonoBehaviour
{
    public AudioClip upgradeSound;
    public Sprite[] img = new Sprite[3];
    public AudioClip buttonClickSound;
    public AudioSource audiosource;
    public Text Title;
    public GameObject popup;
    public int money;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void on_click()
    {
        if (Settings.stationLevel == 0 && Settings.coin >= 1000)
        {


            Settings.stationLevel++;
            Settings.coin -= 1000;
            Title.text = "1500";
            //popup.SetActive(false);
            UpgradeSOund.playSound();
            auto_Save.Save();

        }
        else if (Settings.stationLevel == 1 && Settings.coin >= 1500)
        {
            
            Settings.stationLevel++;
            UpgradeSOund.playSound();

            Settings.coin -= 1500;
            popup.SetActive(false);
            auto_Save.Save();

        }
        else
        {
            ClickSound.playSound();
            auto_Save.Save();

        }
    }
    // Update is called once per frame
    void Update()
    {
        switch (Settings.stationLevel+1)
        {

            case 1:
                money = 1000;
                //Title.text = "1000";
                break;
            case 2:
                money = 1500;
                //Title.text = "1500";

                break;
            case 3:
                popup.SetActive(false);
                break;
        }
        auto_Save.Save();

    }
}
