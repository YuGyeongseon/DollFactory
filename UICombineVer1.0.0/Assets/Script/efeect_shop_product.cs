using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class efeect_shop_product : MonoBehaviour
{
    public int effect_num;
    
    public static int selected;
    public static int num;

   

    public Sprite[] images = new Sprite[10];
    // Start is called before the first frame update
    Image img;

    
    public void product_change()
    {
        
        GetComponent<Image>().sprite = images[effect_shop.effect_list[effect_num]-1];
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        product_change();
    }
}
