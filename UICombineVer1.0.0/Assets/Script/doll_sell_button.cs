using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class doll_sell_button : MonoBehaviour
{

    public static bool sell2 = false;

    public void sell_button1()
    {
        if (Settings.complete_doll >= 1)
        {
            Settings.complete_doll -= 1;
            Settings.coin += 2;
        }

    }



    public void sell_button2()
    {
        if (sell2)
        {
            if (Settings.complete_doll >= 1)
            {
                Settings.complete_doll -= 1;
                Settings.coin += 3;
            }

        }
        else
        {
            if(Settings.incomplete_doll >= 5)
            {
                Settings.incomplete_doll -= 5;
                sell2 = true;
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void but1()
    {
        Settings.complete_doll+=100;
        Settings.incomplete_doll += 100;
        Settings.coin+=100;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
