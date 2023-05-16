using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class doll_ani : MonoBehaviour
{
    public ParticleSystem parti;
    public Sprite[] sprites = new Sprite[3];

    SpriteRenderer spr;



    private void doll_enter()
    {
        spr.sprite = sprites[0];
    }

    private void upgrade(int num)
    {
        spr.sprite = sprites[num];
        parti.SendMessage("particle");
    }

   


    // Start is called before the first frame update
    void Start()
    {
       spr = GetComponent<SpriteRenderer>();

        spr.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
