using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test_004 : MonoBehaviour
{
    public int hp = 180;                         //���� hp ���� 180 �� �Է�  (public�� �ν����� â���� ���̰� �ϱ� ���Ͽ� ���)
    public Text hpText;
    public Text hpStatus;                        //hp ���� ǥ�� ui

    void Update()
    {
        hpStatus.text = hp.ToString();
                                                 //���� hp�� 50 ������ ��

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
            //Debug.Log("����!!");                //console,log â�� �����̶�� ������ �Ѵ�.
            hpText.text = "����!!";
        }
        else if (hp >= 200)                     //���� hp�� 200 �̻��� ��
        {
            //Debug.Log("����!!");                //console.logâ�� �����̶�� ������ �Ѵ�.
            hpText.text = "����!!";
        }
        else                                    //���� �� ������ �ƴҶ�
        {
            //Debug.Log("���!!");                //console.log â�� ����� ������ �Ѵ�.
            hpText.text = "���!!";
        }
    }
}
