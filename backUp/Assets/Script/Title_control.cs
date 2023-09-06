using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class Title_control : MonoBehaviour
{
    Text title;
    LocalizeStringEvent local;


    private void UpdateTitle(int value)
    {
        if (title != null && local != null)
        {
            if (value == 1)
            {
                title.color = Color.black;
                local.StringReference.SetReference("FirstTable", "Buy_Title");
            }
            else
            {
                title.color = Color.red;
                local.StringReference.SetReference("FirstTable", "Fail_to_Buy");
            }
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        title = GetComponent<Text>();
        local  = GetComponent<LocalizeStringEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
