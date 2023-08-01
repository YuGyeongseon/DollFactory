using System.Collections;
using System.Collections.Generic;
//using UnityEditor.U2D;
//using UnityEditor.U2D.Sprites;
using UnityEngine;

public class doll_ani : MonoBehaviour
{
    public ParticleSystem parti;
    public Sprite[] sprites = new Sprite[3];
    SpriteRenderer spr;
    public AudioSource audiosource;
    public AudioClip dollCompleteBgm;
    


    private void doll_enter()
    {
        if (Settings.dollOwned[shopDoll.selectDollNum])
        {
            switch (shopDoll.selectDollNum)
            {
                case 1:
                    spr.sprite = sprites[0];
                    break;
                case 2:
                    spr.sprite = sprites[3];
                    break;
                case 3:
                    spr.sprite = sprites[6];
                    break;
                case 4:
                    spr.sprite = sprites[9];
                    break;
                case 5:
                    spr.sprite = sprites[12];
                    break;
                case 6:
                    spr.sprite = sprites[15];
                    break;
                case 7:
                    spr.sprite = sprites[18];
                    break;
                case 8:
                    spr.sprite = sprites[21];
                    break;
                case 9:
                    spr.sprite = sprites[24];
                    break;
            }
        }
    }

    private void upgrade(int num)
    {
        spr.sprite = sprites[num];
        parti.SendMessage("particle");
        audiosource.PlayOneShot(dollCompleteBgm);
        Debug.Log("¤±");
    }




    // Start is called before the first frame update
    void Start()
    {
       spr = GetComponent<SpriteRenderer>();

       spr.sprite = sprites[Settings.presentDoll];
       Debug.Log(Settings.presentDoll);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
