using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSOund : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject sound;
    void Start()
    {
        sound = GameObject.Find("UpgradeSound");
    }
    public static void playSound()
    {
        if(Settings.is_Sound)
            sound.GetComponent<AudioSource>().Play();  
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
