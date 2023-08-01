using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


//�ִϸ��̼� ��Ʈ�� ��ũ��Ʈ�Դϴ�. animation_controller�� �ΰ����ڵ忡 gameobject�� �߰��ϰ�, sendmessage�� ���ؼ� ������ֽø� �˴ϴ�.
//�ӽ÷� �߰��Ǿ��ִ� buttons�� ��� �׽�Ʈ������ �������ֽø� �˴ϴ�.
//����� �� GenerateDots�� order�迭�� ����մϴ�.

public class ani_con : MonoBehaviour
{
    int num;
    public GameObject belt;
    public GameObject doll;
    int dot1 = 1;
    int dot2 = 2;
    int dot3 = 3;
    //int[] order;


    public void belt_in()   //��Ʈ����
    {
             doll.SendMessage("doll_enter");
             belt.SendMessage("belt_in");
    }

    public void belt_out()  //��Ʈ ����
    {
        belt.SendMessage("belt_out");

    }

    public void doll_1() //���� ù��° ���׷��̵�
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

    public void doll_2()//���� �ι�° ���׷��̵�
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

    public void out_and_in() //��Ʈ ���� 0.7���� �ٽ� ����
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


