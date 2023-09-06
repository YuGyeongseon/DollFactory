using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score = 0;
    public static int previousScore = 0;
    //GameObject DotGenerator = GameObject.Find("DotGenerator");
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        previousScore= 0;
        GameObject DotGenerator = GameObject.Find("DotGenerator");

    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<Text>().text = score.ToString();
        
    }
}
