using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pop_up_buy : MonoBehaviour
{


    public GameObject pop_up;

    public GameObject title;
    public Text coin;
    public GameObject buySound;
    public GameObject coinImg;






    public void buy()
    {


        buySound = GameObject.Find("BuySound");
        if (Settings.coin >= Settings.price[doll_img_cont.doll_no])
        {
            

            doll_img_cont.is_doll[doll_img_cont.doll_no] = true;
            Settings.coin = Settings.coin -Settings.price[doll_img_cont.doll_no];
            shopDoll.Buy();
            Settings.dollOwned[doll_img_cont.doll_no] = true;
            if (Settings.is_Sound)
            {
                buySound.GetComponent<AudioSource>().Play();
            }
            shopDoll.selectDollNum = doll_img_cont.doll_no;
            PlayerPrefs.SetInt("selected", shopDoll.selectDollNum);
            auto_Save.Save();
            Settings.isPopup= false;
            pop_up.SetActive(false);
        }
        else
        {



        }


        

    }

    private void Awake()
    {
        
       
       
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
