using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sell_Button_Doll_Sell : MonoBehaviour
{
    public Text price1;
    public Text price2;
    private int sell_cnt;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void Click()
    {
        ClickSound.playSound();
        Settings.coin += sell_cnt;
        Settings.incomplete_doll -= 3 * sell_cnt;
        //popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        sell_cnt = Settings.incomplete_doll / 3;

        //Title.text = "판매 금액: " + Settings.incomplete_doll+"\n판매하시겠습니까?";
        //price1.text = (Settings.incomplete_doll * 3).ToString();
        //    price2.text = Settings.incomplete_doll.ToString();
        price2.text = (3 * sell_cnt).ToString();
        price1.text = sell_cnt.ToString();


    }
}
