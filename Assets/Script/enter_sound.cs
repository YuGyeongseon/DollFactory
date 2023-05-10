using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Settings.is_Sound)
        {
            gameObject.GetComponent<AudioSource>().Play();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
