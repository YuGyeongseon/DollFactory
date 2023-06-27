using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class notScore : MonoBehaviour
{
    public static int notscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        notscore= 0;
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Text>().text = notscore.ToString();

    }
}
