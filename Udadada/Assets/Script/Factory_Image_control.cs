using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Factory_Image_control : MonoBehaviour
{
    public int dollnum;

    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        Color color = img.color;
        if (Settings.dollOwned[dollnum])
        {
            color.a = 1.0f;
            img.color = color;
        }
        else
        {
            color.a = 0.0f;
            img.color = color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
