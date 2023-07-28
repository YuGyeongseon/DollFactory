using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class main_start_ani_con : MonoBehaviour
{
    Animation ani;
    // Start is called before the first frame update

    private void start()
    {
        ani.PlayQueued("start_main");
        //ani.Play();
    }

    void Start()
    {
        ani = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}