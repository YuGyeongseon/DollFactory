using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_pop_up : MonoBehaviour
{
    private Image button_image;
    public Sprite[] img = new Sprite[3];
    public GameObject popup;
    public Text Title;
    public Text price1;
    public Text price2;


    public GameObject station_img;
    public GameObject price_1;
    public GameObject price_2;
    public GameObject price_3;
    public static int type;
    public AudioClip upgradeSound;
    public AudioClip buttonClickSound;
    public AudioSource audiosource;
    public static int soundUpgradeIndex = 0;
    public static int i = 0;
    public static bool isSell = false;
    public static AudioClip upgradeSound_static;
    public static AudioClip buttonClickSound_static;
    public static AudioSource audiosource_static;
    public void upgrade_popup()
    {
        station_img.SetActive(true);
        price_1.SetActive(true);
        price_2.SetActive(false);
        price_3.SetActive(false);
        type = 1;
        button_image.sprite = img[type];
        Debug.Log("ff");
        popup.SetActive(true);
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

    public void sell_now_popup()
    {

        station_img.SetActive(false);
        price_1.SetActive(false);
        price_2.SetActive(true);
        price_3.SetActive(true);
        type = 2;
        button_image.sprite = img[type];
        isSell = true;
    }

    public void on_click()
    {
        if(type == 1)
        {
            if (repair_station.station_level == 1 && Settings.coin >= 1000)
            {


                repair_station.station_level++;
                Settings.coin -= 1000;
                //popup.SetActive(false);
                audiosource.PlayOneShot(upgradeSound);
                soundUpgradeIndex++;
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
        if(type == 2)
        {

            Settings.coin += Settings.incomplete_doll;
            Settings.incomplete_doll = 0;
            //popup.SetActive(false);
            audiosource.PlayOneShot(buttonClickSound);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false);
        button_image = GetComponent<Image>();
        audiosource_static = audiosource;
        upgradeSound_static = upgradeSound;
        buttonClickSound_static= buttonClickSound;
    }

    // Update is called once per frame
    void Update()
    {
        if(type == 2)
        {
            
            //Title.text = "판매 금액: " + Settings.incomplete_doll+"\n판매하시겠습니까?";
            price1.text = (Settings.incomplete_doll * 3).ToString();
            price2.text = Settings.incomplete_doll.ToString();
        }
        else if (type == 1)
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
}
