using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public static int touch_count = 0; // 터치된 점의 개수
    public static int touch_order = 0; //해당 점이 터치되는 순서가 저장되는 static 변수
    public int num; // 해당점이 생성된 순서가 저장되는 변수
    //public int[] order = new int[3]; //점 터치순서 저장하기 위한 배열
    void Start() 
    {
      //  GameObject DotGenerator = GameObject.Find("DotGenerator");
        //order = DotGenerator.GetComponent<GenerateDots>().order;    
    }

    void OnMouseDown()
    {if (GenerateDots.dot_count >= GenerateDots.order.Length)
        {

            num = touch_order;
            //Debug.Log(touch_count);
            touch_order++;
            touch_count++;
            //GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
 
