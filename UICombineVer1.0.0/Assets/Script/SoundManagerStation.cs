using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerStation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (repair_pop_up.soundUpgradeIndex == 1 && repair_pop_up.i == 0 || repair_pop_up.soundUpgradeIndex == 2 && repair_pop_up.i == 1)
        {
            repair_pop_up.i++;
            repair_pop_up.audiosource_static.PlayOneShot(repair_pop_up.upgradeSound_static);
            Debug.Log("업그레이드 사운드 재생");
        }
        if (repair_pop_up.isSell)
        {
            repair_pop_up.isSell = false;
            repair_pop_up.audiosource_static.PlayOneShot(repair_pop_up.buttonClickSound_static);
            Debug.Log("클릭 사운드 재생");
        }
    }
}
