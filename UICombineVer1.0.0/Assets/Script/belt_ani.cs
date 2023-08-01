using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belt_ani : MonoBehaviour
{


    

    Animation ani;
    

    private void belt_in()
    {
        Debug.Log("BELT IN");
        ani.PlayQueued ("Belt_in");
    }

    private void belt_out()
    {
        Debug.Log("BELT OUT");
        ani.PlayQueued("Belt_out");
    }




    // Start is called before the first frame update
    void Start()
    {

        ani = GetComponent<Animation>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
