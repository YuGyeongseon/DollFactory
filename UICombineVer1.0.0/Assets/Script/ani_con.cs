using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


//애니메이션 컴트롤 스크립트입니다. animation_controller를 인게임코드에 gameobject로 추가하고, sendmessage를 통해서 사용해주시면 됩니다.
//임시로 추가되어있는 buttons는 기능 테스트용으로 삭제해주시면 됩니다.
//변경된 점 GenerateDots의 order배열을 사용합니다.

public class ani_con : MonoBehaviour
{
    int num = 0;
    public GameObject belt;
    public GameObject doll;
    int dot1 = 1;
    int dot2 = 2;
    int dot3 = 3;
    //int[] order;


    public void belt_in()   //벨트등장
    {
             doll.SendMessage("doll_enter");
                belt.SendMessage("belt_in");
    }

    public void belt_out()  //벨트 퇴장
    {
        belt.SendMessage("belt_out");

    }

    public void doll_1() //인형 첫번째 업그레이드
    {
        //Debug.Log("dd");
        switch(shopDoll.selectDollNum)
        {
            case 1:
                doll.SendMessage("upgrade", 1);
                break;
            case 2:
                doll.SendMessage("upgrade", 4);
                break;
            case 3:
                doll.SendMessage("upgrade", 7);
                break;
            case 4:
                doll.SendMessage("upgrade", 10);
                break;
            case 5:
                doll.SendMessage("upgrade", 13);
                break;
            case 6:
                doll.SendMessage("upgrade", 16);
                break;
            case 7:
                doll.SendMessage("upgrade", 19);
                break;
            case 8:
                doll.SendMessage("upgrade", 22);
                break;
            case 9:
                doll.SendMessage("upgrade", 25);
                break;
        }
    }

    public void doll_2()//인형 두번째 업그레이드
    {
        switch (shopDoll.selectDollNum)
        {
            case 1:
                doll.SendMessage("upgrade", 2);
                break;
            case 2:
                doll.SendMessage("upgrade", 5);
                break;
            case 3:
                doll.SendMessage("upgrade", 8);
                break;
            case 4:
                doll.SendMessage("upgrade", 11);
                break;
            case 5:
                doll.SendMessage("upgrade", 14);
                break;
            case 6:
                doll.SendMessage("upgrade", 17);
                break;
            case 7:
                doll.SendMessage("upgrade", 20);
                break;
            case 8:
                doll.SendMessage("upgrade", 23);
                break;
            case 9:
                doll.SendMessage("upgrade", 26);
                break;
        }
    }

    public void out_and_in() //벨트 퇴장 0.7초후 다시 등장
    {
        belt_out();
        Invoke("belt_in", 0.7f);
    }


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        int dotNum = GenerateDots.size;
        if (dotNum == 3)
        {
            dot1 = 1;
            dot2 = 2;
            dot3 = 3;
        }
        else if (dotNum == 4)
        {
            dot1 = 1;
            dot2 = 3;
            dot3 = 4;
        }
        else if (dotNum == 5)
        {
            dot1 = 2;
            dot2 = 4;
            dot3 = 5;
        }
        else if(dotNum == 6)
        {
            dot1 = 2;
            dot2 = 4;
            dot3 = 6;
        }
        else if (dotNum == 7)
        {
            dot1 = 3;
            dot2 = 5;
            dot3 = 7;
        }
        else if (dotNum == 8)
        {
            dot1 = 3;
            dot2 = 6;
            dot3 = 8;
        }
        if (num == 0)
        {
            belt_in();
        }
        num++;
        if (Dot.touch_count == dot1)
        {
            doll_1();
        }
        if (Dot.touch_count ==  dot2)
        {
            doll_2();

            num++;
        }
        if (Dot.touch_count == dot3)
        {
            out_and_in();

        }
    }
}


