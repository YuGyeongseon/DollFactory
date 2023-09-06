using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour
{
    
    public Text txt;
    private int num;

    // Start is called before the first frame update
    public void change()
    {
        if (num == 0)
        {
            txt.text = "loading.";
            num++;
        }
        else if (num ==1)
        {
            txt.text = "loading..";
            num++;
        }
        else
        {
            txt.text = "loading...";
            num = 0 ;
        }
    }

   
        
    void Start()
    {
        txt = GetComponent<Text>();
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("change", 0.05f);
        
        
    }

    
}
