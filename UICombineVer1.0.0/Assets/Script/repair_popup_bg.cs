using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class repair_popup_bg : MonoBehaviour
{

    public Sprite[] img = new Sprite[3];

    private Image bg_img;

    // Start is called before the first frame update
    void Start()
    {
        bg_img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        bg_img.sprite = img[repair_pop_up.type];
    }
}
