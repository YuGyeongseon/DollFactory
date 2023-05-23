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
        Debug.Log("dd");
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

        if (num == 0)
        {
            belt_in();
        }
        num++;
        Debug.Log(num);
        if (GenerateDots.order[0] == 1)
        {
            doll_1();
        }
        if (GenerateDots.order[1] == 2&& GenerateDots.order[0] == 1)
        {
            doll_2();

            num++;
        }
        if (GenerateDots.order[2] == 3&& GenerateDots.order[1] == 2 && GenerateDots.order[0] == 1)
        {
            out_and_in();

        }
    }
}


