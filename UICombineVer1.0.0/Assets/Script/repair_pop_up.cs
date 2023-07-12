using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_pop_up : MonoBehaviour
{
    public GameObject popup;
    public Text Title;

    private int type;

    public void upgrade_popup()
    {
        type = 1;
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
        type = 2;

    }

    public void on_click()
    {
        if(type == 1)
        {
            if (repair_station.station_level == 1 && Settings.coin >= 1000)
            {
                repair_station.station_level++;
                Settings.coin -= 1000;
                popup.SetActive(false);
            }
            else if (repair_station.station_level == 2 && Settings.coin >= 1500)
            {
                repair_station.station_level++;
                Settings.coin -= 1500;
                popup.SetActive(false);
            }
            else
            {
                Title.text = "코인이 부족합니다.";
                
            }

        }
        if(type == 2)
        {
            Settings.coin += Settings.incomplete_doll;
            Settings.incomplete_doll = 0;
            popup.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(type == 2)
        {
            Title.text = "판매 금액: " + Settings.incomplete_doll+"\n판매하시겠습니까?";
        }
    }
}
