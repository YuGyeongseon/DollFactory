using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effect_shop_buy_button : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject popup;
    private Image but;
 
    public void buy()
    {

        

        
        if (!Settings.effect_owned[effect_shop.effect_list[1]])
        {
            popup.SetActive(true);
        }
        else
        {

            Debug.Log("already_owned");
        }
        
    }
    void Start()
    {
        but = GetComponent<Image>();
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Settings.effect_owned[effect_shop.effect_list[1]])
        {
            but.color = new Color(1.0f, 1.0f, 1.0f);
        }
        else
        {
            but.color = new Color(0.3f, 0.3f, 0.3f);
        }
    }
}
