using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_shop_incom_doll : MonoBehaviour
{
    public Sprite[] dolls = new Sprite[5];

    

    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Settings.incomplete_doll==0)
        {
            img.sprite = dolls[1];
        }
        else if (Settings.incomplete_doll <= repair_station.storage[repair_station.station_level]/4) 
        {
            img.sprite= dolls[1];
        }
        else if(Settings.incomplete_doll <= repair_station.storage[repair_station.station_level] / 4 * 2)
        {
            img.sprite= dolls[2];
        }
        else if (Settings.incomplete_doll <= repair_station.storage[repair_station.station_level] / 4 * 3)
        {
            img.sprite = dolls[3];
        }
        else
        {
            img.sprite = dolls[4];
        }
    }
}
