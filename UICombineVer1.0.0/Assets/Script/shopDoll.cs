using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class shopDoll : MonoBehaviour
{
    Image img;
    public int doll_num;


    public GameObject pop_up;

    public GameObject title;

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


        
        
        if (doll_num == doll_img_cont.doll_no && doll_img_cont.is_doll[doll_num] == false) {


            if (Settings.is_Sound)
            {
                gameObject.GetComponent<AudioSource>().Play();

            }

           
            pop_up.SetActive(true);
            title.SendMessage("String", 1);


        }
        else
        {
            if (Settings.is_Sound)
            {
                gameObject.GetComponent<AudioSource>().Play();

            }
            doll_img_cont.doll_no = doll_num; //인형 번호
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {

        img = GetComponent<Image>();

        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (doll_img_cont.is_doll[doll_num])
        {
            if (doll_num == doll_img_cont.doll_no)
            {
                img.color = new Color(1.0f, 1.0f, 1.0f);
            }
            else
            {
                img.color = new Color(0.5f, 0.5f, 0.5f);
            }
        }
        else if (doll_num == doll_img_cont.doll_no)
        {
            img.color = new Color(0.25f, 0.25f, 0.25f);
        }
        else
        {
            img.color = new Color(0.0f, 0.0f, 0.0f);
        }

    }
}
