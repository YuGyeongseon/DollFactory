using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_select_save : MonoBehaviour
{

    public void on_click()
    {
        Settings.effect_selected = effect_select_button.selected;

        Debug.Log(Settings.effect_selected);

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
