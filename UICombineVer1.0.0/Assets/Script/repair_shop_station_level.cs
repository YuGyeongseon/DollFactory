using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_shop_station_level : MonoBehaviour
{
    public Sprite[] stations = new Sprite[3];
    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
        img.sprite = stations[repair_station.station_level - 1];
    }
}
