using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Button : MonoBehaviour
{

    public void Play_button()
    {
        //Settings.vibrate();
        Handheld.Vibrate();
        SceneManager.LoadScene("Game_Scene");
        
        
    }


    public void Setting_button()
    {
        SceneManager.LoadScene("Setting_Scene");
        
    }


    public void Shop_button()
    {
        SceneManager.LoadScene("Shop_Scene");
        

    }

    public void Achive_button()
    {
        Debug.Log("ACHIVE");
        
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
