using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpSOund : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject sound;
    void Start()
    {
        sound = GameObject.Find("PopUpSound");
    }

    public static void playSound()
    {
        if (Settings.is_Sound)
        {
            sound.GetComponent<AudioSource>().Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
