using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class dollNum : MonoBehaviour
{
    public static float doll_amount;
    public static int previousdoll_amount;
    // Start is called before the first frame update
    void Start()
    {
        doll_amount = 0;
        previousdoll_amount = 0;
        GameObject DotGenerator = GameObject.Find("DotGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = doll_amount.ToString();
    }
}
