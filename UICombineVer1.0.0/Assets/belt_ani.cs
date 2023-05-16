using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belt_ani : MonoBehaviour
{


    

    Animation ani;
    

    private void belt_in()
    {


        ani.PlayQueued ("Belt_in");
    }

    private void belt_out()
    {

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
