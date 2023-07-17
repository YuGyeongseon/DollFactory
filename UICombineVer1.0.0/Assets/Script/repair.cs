using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repair : MonoBehaviour
{
    public static float timer;
    // Start is called before the first frame update
    private void Awake()
    {
        var obj = FindObjectsOfType<repair>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Settings.incomplete_doll > 0)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer.ToString());
            if(timer >= repair_station.speed[repair_station.station_level]) {
                Settings.incomplete_doll--;
                //repair_station.repair_doll++;
                Settings.complete_doll++;
                timer -= repair_station.speed[repair_station.station_level];
            }
        }

        if (Settings.incomplete_doll >= repair_station.storage[repair_station.station_level])
        {
            Settings.incomplete_doll = repair_station.storage[repair_station.station_level];
        }
    }
}
