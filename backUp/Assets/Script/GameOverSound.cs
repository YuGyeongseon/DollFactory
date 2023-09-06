using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject sound;

    void Start()
    {
        sound = GameObject.Find("gameOverSound");
    }

    public static void playSound()
    {
        if (Settings.is_BGM)
        {
            sound.GetComponent<AudioSource>().Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
