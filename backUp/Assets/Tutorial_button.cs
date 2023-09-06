using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_button : MonoBehaviour
{
    public GameObject back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_click()
    {
        if(Tutorial.tuto_page == 1)
        {
            back.SendMessage("tutorial2");
            Debug.Log("dd");
        }
        else
        {
            SceneManager.LoadScene("Game_Scene");
            Page_control.pagenum = 7;
        }
    }

    
}
