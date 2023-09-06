using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dollSlideSound : MonoBehaviour
{
    public static GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.Find("dollSlideSound");
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
