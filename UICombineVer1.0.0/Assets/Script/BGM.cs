using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(transform.gameObject);
        if (Settings.is_BGM)
        {
            gameObject.GetComponent<AudioSource>().Play();

        }
        
      
    }

    // Update is called once per frame
  
}
