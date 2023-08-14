using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_controller : MonoBehaviour
{

    public static ParticleSystem ps;

    
    public static void changeColorYellow()
    {
        ps.startColor = Color.yellow;
    }
    public static void changeColorWhite()
    {
        ps.startColor = Color.white;
    }
    private void particle()
    {

        

        //ps.Play();
    }



    // Start is called before the first frame update
    void Start()
    {
        ps= GetComponent<ParticleSystem>();

       

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
