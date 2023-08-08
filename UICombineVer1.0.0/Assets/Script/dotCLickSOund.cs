using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotCLickSOund : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject sound;
    void Start()
    {
        sound = GameObject.Find("dotClickSound");
    }
    public static void playSound()
    {
        if(Settings.is_Sound)
        {
            sound.GetComponent<AudioSource>().Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
