using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_up_cancel : MonoBehaviour
{


    public GameObject pop_up;
    public GameObject buttonSound;

    public void cancel()
    {
        buttonSound = GameObject.Find("ClickSound");
        if (Settings.is_Sound)
        {
            buttonSound.gameObject.GetComponent<AudioSource>().Play();
        }
        pop_up.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        pop_up.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
