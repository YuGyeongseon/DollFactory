using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;


public class Sell_Button_Doll_Sell : MonoBehaviour
{
    public Text price1;
    public Text price2;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void Click()
    {
        Settings.coin += Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
        //popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

            //Title.text = "�Ǹ� �ݾ�: " + Settings.incomplete_doll+"\n�Ǹ��Ͻðڽ��ϱ�?";
            price1.text = (Settings.incomplete_doll * 3).ToString();
            price2.text = Settings.incomplete_doll.ToString();
        
    }
}
