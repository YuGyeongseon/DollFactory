using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopDoll : MonoBehaviour
{
    public Text textObjectProfitablity;
    public Text textObjectCircleNum;
    public Text textObjectMaxspeed;
    public string profitablity;
    public string circleNum;
    public string maxSpeed;

    public void OnClick()
    {
        textObjectProfitablity.text = profitablity;
        textObjectCircleNum.text = circleNum;
        textObjectMaxspeed.text = maxSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
