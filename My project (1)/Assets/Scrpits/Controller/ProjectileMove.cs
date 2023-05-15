using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE                                  //총알 타입 구분을 위해 Enum선언                     
    {
        PLAYER,
        ENEMY
    }
    
    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;                       //총알 타입 선언


    private void OnCollisionEnter(Collision collision)                              //Trigger 함수
    {
        if (collision.gameObject.name == "Wall")                                    //Name -> Tag로 전환
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }

    private void OnTriggerEnter(Collider other)
    {   //벽에 충돌시 파괴
        if (other.gameObject.tag == "Wall")                                 
        {
            Destroy(this.gameObject);
        }
        //몬스터에 충돌시
        if (other.gameObject.tag == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            //몬스터에게 데미지를 주고 사라진다.
            other.gameObject.GetComponent<MonsterController>().Damaged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f),0.1f, 10, 1);
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            //플레이어에게 데미지를 주고 사라진다
            other.gameObject.GetComponent<PlayerController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }


}
