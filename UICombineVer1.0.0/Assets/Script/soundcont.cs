using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundcont : MonoBehaviour
{

    public Sprite[] sprites = new Sprite[2]; //�̹��� ���� 0 = on 1 = off
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Settings.is_Sound)
        {
            img.sprite = sprites[0];
        }
        else
        {
            img.sprite = sprites[1];
        }
    }
}
