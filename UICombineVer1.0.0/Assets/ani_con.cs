using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//애니메이션 컴트롤 스크립트입니다. animation_controller를 인게임코드에 gameobject로 추가하고, sendmessage를 통해서 사용해주시면 됩니다.
//임시로 추가되어있는 buttons는 기능 테스트용으로 삭제해주시면 됩니다.


public class ani_con : MonoBehaviour
{

    public GameObject belt;
    public GameObject doll;

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
        doll.SendMessage("upgrade",1);
    }

    public void doll_2()//인형 두번째 업그레이드
    {
        doll.SendMessage("upgrade",2);
    }

    public void out_and_in() //벨트 퇴장 0.7초후 다시 등장
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
        
    }
}
