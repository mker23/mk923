using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test_004 : MonoBehaviour
{
    public int hp = 180;                         //변수 hp 선언 180 값 입력  (public운 인스펙터 창에서 보이게 하기 위하여 사용)
    public Text hpText;
    public Text hpStatus;                        //hp 슛저 표사 ui

    void Update()
    {
        hpStatus.text = hp.ToString();
                                                 //변수 hp가 50 이하일 때

        if (Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }
        if (hp <= 50)
        {
            //Debug.Log("도망!!");                //console,log 창에 도망이라고 나오게 한다.
            hpText.text = "도망!!";
        }
        else if (hp >= 200)                     //변수 hp가 200 이상일 때
        {
            //Debug.Log("공격!!");                //console.log창에 공격이라고 나오게 한다.
            hpText.text = "공격!!";
        }
        else                                    //위의 두 조건이 아닐때
        {
            //Debug.Log("방어!!");                //console.log 창에 방어라고 나오게 한다.
            hpText.text = "방어!!";
        }
    }
}
