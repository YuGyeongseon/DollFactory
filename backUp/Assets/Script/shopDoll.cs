using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;



public class shopDoll : MonoBehaviour
{


    public string Name;

    public Image img;
    public int doll_num;
    public static bool isBuy;
    public static int selectDollNum;
    public GameObject pop_up;
    public GameObject title;

    public Text coin;
    public Image doll_img;

    public Sprite doll_imgs;

    public Text textObjectProfitablity;
    public Text textObjectCircleNum;
    public Text textObjectMaxspeed;


    public string defect_rate;
    public string fever_rate;

    public Sprite[] new_img = new Sprite[2];

    public static void Buy()
    {
        isBuy = true;
    }

    public void OnClick()
    {
        Locale currentLanguage = LocalizationSettings.SelectedLocale;
        textObjectProfitablity.text = "<" + LocalizationSettings.StringDatabase.GetLocalizedString("FirstTable", doll_num.ToString(), currentLanguage) + ">";
        textObjectCircleNum.text = LocalizationSettings.StringDatabase.GetLocalizedString("FirstTable", "cost", currentLanguage)+": " +Settings.price[doll_num].ToString() + " Coin";
        textObjectMaxspeed.text = LocalizationSettings.StringDatabase.GetLocalizedString("FirstTable", "defect_rate", currentLanguage)+": " +defect_rate +"   "+ LocalizationSettings.StringDatabase.GetLocalizedString("FirstTable", "fever_rate", currentLanguage) + ": "+fever_rate;

        Debug.Log(currentLanguage);


        if (doll_num == doll_img_cont.doll_no && doll_img_cont.is_doll[doll_num] == false)
        {


            if (Settings.is_Sound)
            {
                gameObject.GetComponent<AudioSource>().Play();

            }

            if (!Settings.dollOwned[doll_img_cont.doll_no])
            {
                Settings.isPopup= true;
                pop_up.SetActive(true);

            }
            else
            {
                Debug.Log("IsOwned");
            }

            coin.text = Settings.price[doll_num].ToString();
            doll_img.sprite = doll_imgs;


        }
        else
        {
            if (Settings.is_Sound)
            {
                gameObject.GetComponent<AudioSource>().Play();
                //selectDollNum = doll_num;

            }
            doll_img_cont.doll_no = doll_num; //���� ��ȣ
            if (Settings.dollOwned[doll_num] == true)
            {
                selectDollNum= doll_num;
                PlayerPrefs.SetInt("selected", selectDollNum);
            }
            else
            {

            }

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
        
        if (Settings.dollOwned[doll_num])
        {
            img.sprite = new_img[0];
            if (doll_num == doll_img_cont.doll_no)
            {
                //img.color = new Color(1.0f, 1.0f, 1.0f);
                img.rectTransform.sizeDelta = new Vector2(300, 300);
            }
            else
            {
                //img.color = new Color(0.5f, 0.5f, 0.5f);
                img.rectTransform.sizeDelta = new Vector2(260, 260);
            }
        }
        else if (doll_num == doll_img_cont.doll_no)
        {
            //img.color = new Color(0.25f, 0.25f, 0.25f);
            img.sprite = new_img[1];
        }
        else
        {
            //img.color = new Color(0.0f, 0.0f, 0.0f);
            img.sprite = new_img[1];
        }

    }

}