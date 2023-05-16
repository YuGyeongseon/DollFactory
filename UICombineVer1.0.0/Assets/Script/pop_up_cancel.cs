using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop_up_cancel : MonoBehaviour
{


    public GameObject pop_up;


    public void cancel()
    {

        if (Settings.is_Sound)
        {
            gameObject.GetComponent<AudioSource>().Play();

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
