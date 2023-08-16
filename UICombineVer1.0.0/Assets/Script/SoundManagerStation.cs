using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerStation : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip buttonClick;
    public AudioClip upgrade;
    void Start()
    {
        var obj = FindObjectsOfType<effect_shop>();
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
        if (repair_pop_up.soundUpgradeIndex == 1 && repair_pop_up.i == 0 || repair_pop_up.soundUpgradeIndex == 2 && repair_pop_up.i == 1)
        {
            repair_pop_up.i++;
            audioSource.PlayOneShot(upgrade);
            Debug.Log("업그레이드 사운드 재생");
        }
        if (repair_pop_up.isSell)
        {
            repair_pop_up.isSell = false;
            audioSource.PlayOneShot(buttonClick);
            Debug.Log("클릭 사운드 재생");
        }
    }
}
