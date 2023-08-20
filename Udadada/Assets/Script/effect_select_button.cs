using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effect_select_button : MonoBehaviour
{

    public int effect_num;
    public Image effect_img;
    private Image img;

    public static int selected;

    public Sprite[] spr = new Sprite[2];
    // Start is called before the first frame update

    public void on_click()
    {
        ClickSound.playSound();
        if (Settings.effect_owned[effect_num])
        {
            selected = effect_num;
            
        }
        

    }

    void Start()
    {
        img = GetComponent<Image>();

        selected = Settings.effect_selected;
    }
      
    // Update is called once per frame
    void Update()
    {
        if (Settings.effect_owned[effect_num])
        {
            //effect_img.sprite = spr[1];
            img.color = new Color(1.0f, 1.0f, 1.0f);
        }
        else
        {
            //effect_img.sprite = spr[0];
            img.color = new Color(0.1f, 0.1f, 0.1f);
        }

        if(selected == effect_num&& Settings.effect_owned[effect_num])
        {
            effect_img.sprite = spr[1];
        }
        else
        {
            effect_img.sprite = spr[0];
        }


    }
}
