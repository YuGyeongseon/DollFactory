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
        if (GenerateDots.timer > GenerateDots.tpd * GenerateDots.order.Length + 1)
        {
            time.value -= (Time.deltaTime / 3);
        }
        else if (GenerateDots.timer == 0)
        {
            time.value = 1;
        }
    }
}