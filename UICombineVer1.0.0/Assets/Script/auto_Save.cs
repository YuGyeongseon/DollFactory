using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class auto_Save : MonoBehaviour
{


    public static void Save()
    {
        PlayerPrefs.SetInt("coin", Settings.coin);
        PlayerPrefs.SetInt("com_doll", Settings.complete_doll);
        PlayerPrefs.SetInt("incom_doll", Settings.incomplete_doll);

        Debug.Log("saved!");
    }

    private float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {

        Settings.coin = PlayerPrefs.GetInt("coin");
        Settings.complete_doll = PlayerPrefs.GetInt("com_doll");
        Settings.incomplete_doll = PlayerPrefs.GetInt("incom_doll");

        var obj = FindObjectsOfType<auto_Save>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 10)
        {
            
            Save();
            Timer = 0;

            
            
        }

            
        

    }
}
