using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_popup_buy : MonoBehaviour
{
    public GameObject popup;
    public void on_click()
    {
        ClickSound.playSound();
        if (!Settings.effect_owned[effect_shop.effect_list[1]])
        {
            if (Settings.bear_doll >= 20)
            {
                Settings.bear_doll -= 20;
                Settings.effect_owned[effect_shop.effect_list[1]] = true;
            }
            else
            {
                Debug.Log("not enough");
            }
        }
        else
        {
            Debug.Log("already_owned");
        }
        popup.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
