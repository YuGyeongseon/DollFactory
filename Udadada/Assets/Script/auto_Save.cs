using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class auto_Save : MonoBehaviour
{


    public static void Save()
    {
        PlayerPrefs.SetInt("coin", Settings.coin);
        PlayerPrefs.SetInt("com_doll", Settings.complete_doll);
        PlayerPrefs.SetInt("incom_doll", Settings.incomplete_doll);
        PlayerPrefs.SetInt("bear_doll", Settings.bear_doll);
        PlayerPrefs.SetInt("repairStation", Settings.stationLevel);



        /*
        for (int i = 1; i <= 9; i++)
        {
            PlayerPrefs.SetInt("dollowned" + i.ToString(), System.Convert.ToInt16(Settings.dollOwned[i]));
        }
        */


        PlayerPrefs.SetInt("dollowned1", System.Convert.ToInt16(Settings.dollOwned[1]));
        PlayerPrefs.SetInt("dollowned2", System.Convert.ToInt16(Settings.dollOwned[2]));
        PlayerPrefs.SetInt("dollowned3", System.Convert.ToInt16(Settings.dollOwned[3]));
        PlayerPrefs.SetInt("dollowned4", System.Convert.ToInt16(Settings.dollOwned[4]));
        PlayerPrefs.SetInt("dollowned5", System.Convert.ToInt16(Settings.dollOwned[5]));
        PlayerPrefs.SetInt("dollowned6", System.Convert.ToInt16(Settings.dollOwned[6]));
        PlayerPrefs.SetInt("dollowned7", System.Convert.ToInt16(Settings.dollOwned[7]));
        PlayerPrefs.SetInt("dollowned8", System.Convert.ToInt16(Settings.dollOwned[8]));
        PlayerPrefs.SetInt("dollowned9", System.Convert.ToInt16(Settings.dollOwned[9]));

        PlayerPrefs.SetInt("effect_owned0", System.Convert.ToInt16(Settings.effect_owned[0]));
        PlayerPrefs.SetInt("effect_owned1", System.Convert.ToInt16(Settings.effect_owned[1]));
        PlayerPrefs.SetInt("effect_owned2", System.Convert.ToInt16(Settings.effect_owned[2]));
        PlayerPrefs.SetInt("effect_owned3", System.Convert.ToInt16(Settings.effect_owned[3]));
        PlayerPrefs.SetInt("effect_owned4", System.Convert.ToInt16(Settings.effect_owned[4]));
        PlayerPrefs.SetInt("effect_owned5", System.Convert.ToInt16(Settings.effect_owned[5]));
        PlayerPrefs.SetInt("effect_owned6", System.Convert.ToInt16(Settings.effect_owned[6]));
        PlayerPrefs.SetInt("effect_owned7", System.Convert.ToInt16(Settings.effect_owned[7]));
        PlayerPrefs.SetInt("effect_owned8", System.Convert.ToInt16(Settings.effect_owned[8]));
        PlayerPrefs.SetInt("effect_owned9", System.Convert.ToInt16(Settings.effect_owned[9]));
        PlayerPrefs.SetInt("effect_owned10", System.Convert.ToInt16(Settings.effect_owned[10]));
        PlayerPrefs.SetInt("effect_owned11", System.Convert.ToInt16(Settings.effect_owned[11]));




        Debug.Log("saved!");
    }

    private float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {

        Settings.coin = PlayerPrefs.GetInt("coin");
        Settings.stationLevel = PlayerPrefs.GetInt("repairStation");

        Settings.complete_doll = PlayerPrefs.GetInt("com_doll");
        Settings.incomplete_doll = PlayerPrefs.GetInt("incom_doll");
        Settings.bear_doll = PlayerPrefs.GetInt("bear_doll");

        /*
        for (int i = 1; i <= 9; i++) {
            Settings.dollOwned[i] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned"+i.ToString()));

            Debug.Log(Settings.dollOwned[i].ToString());
            }
        */

        //Settings.dollOwned[1] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned1"));
        Settings.dollOwned[2] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned2"));
        Settings.dollOwned[3] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned3"));
        Settings.dollOwned[4] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned4"));
        Settings.dollOwned[5] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned5"));
        Settings.dollOwned[6] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned6"));
        Settings.dollOwned[7] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned7"));
        Settings.dollOwned[8] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned8"));
        Settings.dollOwned[9] = System.Convert.ToBoolean(PlayerPrefs.GetInt("dollowned9"));

        Settings.effect_owned[0] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned0"));
        Settings.effect_owned[1] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned1"));
        Settings.effect_owned[2] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned2"));
        Settings.effect_owned[3] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned3"));
        Settings.effect_owned[4] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned4"));
        Settings.effect_owned[5] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned5"));
        Settings.effect_owned[6] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned6"));
        Settings.effect_owned[7] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned7"));
        Settings.effect_owned[8] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned8"));
        Settings.effect_owned[9] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned9"));
        Settings.effect_owned[10] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned10"));
        Settings.effect_owned[11] = System.Convert.ToBoolean(PlayerPrefs.GetInt("effect_owned11"));




        var obj = FindObjectsOfType<auto_Save>();
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
        Timer += Time.deltaTime;

        if (Timer > 10)
        {

            Save();
            Timer = 0;



        }




    }
}
