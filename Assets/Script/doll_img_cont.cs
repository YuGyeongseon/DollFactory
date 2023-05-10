using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doll_img_cont : MonoBehaviour
{
    public static int doll_no = 1;

    public static bool[] is_doll = new bool[10];

    


    public Sprite[] sprites = new Sprite[10];
    Image img;



    // Start is called before the first frame update
    void Start()
    {
        Settings.coin = 100; // 돈 설정 (저장 x)

        if (Settings.is_Sound)
        {
            gameObject.GetComponent<AudioSource>().Play();

        }

        img = GetComponent<Image>();

        is_doll[1] = true;              //인형 소지 여부 초기화(임시)
        for (int i = 2; i <= 9; i++)
        {
            is_doll[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        img.sprite = sprites[doll_no];
    }
}
