using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class upgrade_pop_up : MonoBehaviour
{
    public AudioClip upgradeSound;
    public Sprite[] img = new Sprite[3];
    public AudioClip buttonClickSound;
    public AudioSource audiosource;
    public Text Title;
    public GameObject popup;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void on_click()
    {
        if (repair_station.station_level == 1 && Settings.coin >= 1000)
        {


            repair_station.station_level++;
            Settings.coin -= 1000;
            //popup.SetActive(false);
            audiosource.PlayOneShot(upgradeSound);
        }
        else if (repair_station.station_level == 2 && Settings.coin >= 1500)
        {

            repair_station.station_level++;

            Settings.coin -= 1500;
            //popup.SetActive(false);
            audiosource.PlayOneShot(upgradeSound);
        }
        else
        {
            audiosource.PlayOneShot(buttonClickSound);

            Title.text = "코인이 부족합니다.";

        }
    }
    // Update is called once per frame
    void Update()
    {
        switch (repair_station.station_level)
        {

            case 1:

                Title.text = "1000 coin";

                break;
            case 2:

                Title.text = "1500 coin";

                break;
            case 3:
                popup.SetActive(false);
                break;
        }
    }
}
