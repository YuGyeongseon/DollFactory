using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�ִϸ��̼� ��Ʈ�� ��ũ��Ʈ�Դϴ�. animation_controller�� �ΰ����ڵ忡 gameobject�� �߰��ϰ�, sendmessage�� ���ؼ� ������ֽø� �˴ϴ�.
//�ӽ÷� �߰��Ǿ��ִ� buttons�� ��� �׽�Ʈ������ �������ֽø� �˴ϴ�.


public class ani_con : MonoBehaviour
{
    int num = 0;
    public GameObject belt;
    public GameObject doll;

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
        doll.SendMessage("upgrade",1);
    }

    public void doll_2()//���� �ι�° ���׷��̵�
    {
        doll.SendMessage("upgrade",2);
    }

    public void out_and_in() //��Ʈ ���� 0.7���� �ٽ� ����
    {
        belt_out();
        Invoke( "belt_in", 0.7f);
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(num == 0)
        {
            belt_in();
        }
        if(Score.previousScore<Score.score)
        {
            if(Score.score%3 == 1)
            {
                doll_1();
            }
            else if(Score.score%3 == 2)
            {
                doll_2();
            }
            else if(Score.score%3 == 0)
            {
                out_and_in();
            }
        }
        Score.previousScore = Score.score;
        num = 1;
    }
}
