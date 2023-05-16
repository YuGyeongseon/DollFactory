using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pop_up_buy : MonoBehaviour
{


    public GameObject pop_up;

    public Text title;
    public Text coin;

    


    

    public void buy()
    {

       

        if (Settings.coin >= Settings.price[doll_img_cont.doll_no])
        {
            

            doll_img_cont.is_doll[doll_img_cont.doll_no] = true;
            Settings.coin = Settings.coin -Settings.price[doll_img_cont.doll_no];
            coin.text = Settings.coin.ToString();
            
            pop_up.SetActive(false);
        }
        else
        {

            title.color = Color.red;
            title.text = "코인이 부족합니다.";

            if (Settings.is_Sound)
            {
                gameObject.GetComponent<AudioSource>().Play();

            }
            
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
