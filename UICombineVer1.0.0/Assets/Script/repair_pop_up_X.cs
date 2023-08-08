using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repair_pop_up_X : MonoBehaviour
{
    public GameObject popup;
    public void on_click()
    {
        ClickSound.playSound();
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
