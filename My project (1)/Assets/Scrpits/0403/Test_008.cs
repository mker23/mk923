using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player
{
    private int hp = 100;                                                               //hp�� ������ �� 100�� ���� �Է�
    private int Power = 50;                                                             //power�� ������ �� 50�� ���� �Է�
    public void Attack()
    {
        Debug.Log(this.Power + "�������� ������.");                                     //this�� Player Ŭ������ �̾߱��Ѵ�.
    }

    public void Damage(int damage)                                                      //Damage �Լ��� int ���·� ���� ������ �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� ������.");
    }

    public int GetHp()                                                                  //private �� ����Ǿ��ִ� Hp ���� ���� �Լ��� ���ؼ� ���٤�
    {
        return this.hp;
    }
}
public class Test_008 : MonoBehaviour
{
    player player_01 = new player();                                                   //���� ���� �÷��̾� Ŭ������ �����Ѵ�. (������ ����ϱ� ���ؼ�)        
    player player_02 = new player();                                                   //���� ���� �÷��̾� Ŭ������ �����Ѵ�. (������ ����ϱ� ���ؼ�)
    public Text player01HP;                                                            //�÷��̾� HP�� �����ִ� UI ����
    public Text player02HP;                                                             //�÷��̾� HP�� �����ִ� UI ����

    // Start is called before the first frame update
    void Start()
    {
                                                                                  //���� ���� �÷��̾� Ŭ������ �����Ѵ�. 
        player_01.Attack();                                                              //������ player_01 �� attack �Լ��� �����Ų��.
        player_01.Damage(30);                                                            //������ Player_01 �� Damage �Լ��� �����Ų��. (�μ� 30�� �־��ش�.)
    }

    // Update is called once per frame
    void Update()
    {
        player01HP.text = "Player 01 HP : " + player_01.GetHp().ToString();     
        player02HP.text = "Player 02 HP : " + player_02.GetHp().ToString();

        if(Input.GetMouseButton(0))                                                             
        {
            player_01.Damage(1);
        }

        if (Input.GetMouseButton(1))
        {
            player_02.Damage(1);
        }
    }
}
