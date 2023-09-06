using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerInGema : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip create;
    public AudioClip click;
    public static SoundManagerInGema instance;
    void Start()
    {
        
    }
    private void Awake()
    {
        if(SoundManagerInGema.instance != null)
        {
            SoundManagerInGema.instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClickSound()
    {
        audioSource.PlayOneShot(click);
    }

    public void PlayCreateSound()
    {
        audioSource.PlayOneShot(create);
    }
}
