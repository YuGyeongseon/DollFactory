using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class back_to_main : MonoBehaviour
{


    public void back()
    {
        ClickSound.playSound();
        if(Main_Button.isSetting)
        {
            Main_Button.isSetting = false;
        }
        SceneManager.LoadScene("Main_Scene");
        GenerateDots.timer = 0;
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