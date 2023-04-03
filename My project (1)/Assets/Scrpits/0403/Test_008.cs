using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player
{
    private int hp = 100;                                                               //hp를 선언한 후 100의 값을 입력
    private int Power = 50;                                                             //power를 선언한 후 50의 값을 입력
    public void Attack()
    {
        Debug.Log(this.Power + "데미지를 입혔다.");                                     //this는 Player 클래스를 이야기한다.
    }

    public void Damage(int damage)                                                      //Damage 함수는 int 형태로 받은 데미지 인수를 받는다.
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입혔다.");
    }

    public int GetHp()                                                                  //private 로 선언되어있는 Hp 변수 값을 함수로 통해서 전다ㅏ
    {
        return this.hp;
    }
}
public class Test_008 : MonoBehaviour
{
    player player_01 = new player();                                                   //위에 만든 플레이어 클래스를 선언한다. (전역에 사용하기 위해서)        
    player player_02 = new player();                                                   //위에 만든 플레이어 클래스를 선언한다. (전역에 사용하기 위해서)
    public Text player01HP;                                                            //플레이어 HP를 보여주는 UI 선언
    public Text player02HP;                                                             //플레이어 HP를 보여주는 UI 선언

    // Start is called before the first frame update
    void Start()
    {
                                                                                  //위에 만든 플레이어 클래스를 선언한다. 
        player_01.Attack();                                                              //생성한 player_01 의 attack 함수를 실행시킨다.
        player_01.Damage(30);                                                            //생성한 Player_01 의 Damage 함수를 실행시킨다. (인수 30을 넣어준다.)
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
