using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    public static int x=1;
    public static GameObject Bgm;
    void Start()
    {
        Bgm = GameObject.Find("BGM");
        DontDestroyOnLoad(transform.gameObject);
        
        if (Settings.is_BGM && x==1)
        {
            Debug.Log("MUSIC");
            Bgm.GetComponent<AudioSource>().Play();
            x++;
        }
        if(Settings.is_BGM == false)
        {
            Bgm.GetComponent<AudioSource>().Pause();
            Debug.Log("Pause");
        }


    }
    void Update()
    {
    }
    // Update is called once per frame

}
