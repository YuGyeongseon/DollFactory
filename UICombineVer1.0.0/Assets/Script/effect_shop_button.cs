using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class effect_shop_button: MonoBehaviour
{

    public Image img;

    public void buy()
    {

        if (!Settings.effect_owned[effect_shop.effect_list[1]])
        {
            if (Settings.bear_doll >= 20)
            {
                Settings.bear_doll -= 20;
                Settings.effect_owned[effect_shop.effect_list[1]] = true;
            }
            else{
                Debug.Log("not enough");
            }
        }
        else
        {
            Debug.Log("already_owned");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Settings.effect_owned[effect_shop.effect_list[1]])
        {
            img.color = new Color(1.0f, 1.0f, 1.0f);
        }
        else
        {
            img.color = new Color(0.3f, 0.3f, 0.3f);
        }
    }
}
