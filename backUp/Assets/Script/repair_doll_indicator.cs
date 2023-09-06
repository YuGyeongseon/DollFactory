using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class repair_doll_indicator : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = repair_station.repair_doll.ToString() + " / " + repair_station.storage[repair_station.station_level].ToString();
    }
}
