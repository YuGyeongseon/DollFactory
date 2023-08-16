using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_gauge : MonoBehaviour
{
    [SerializeField] private Slider time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GenerateDots.cycle_timer > GenerateDots.dotgenTime + GenerateDots.vanish)
        {
            time.value -= (Time.deltaTime );
        }
        else if (GenerateDots.cycle_timer == 0)
        {
            time.value = 1;
        }
    }
}