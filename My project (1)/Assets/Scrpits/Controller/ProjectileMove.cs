using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE                                  //�Ѿ� Ÿ�� ������ ���� Enum����                     
    {
        PLAYER,
        ENEMY
    }
    
    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;                       //�Ѿ� Ÿ�� ����


    private void OnCollisionEnter(Collision collision)                              //Trigger �Լ�
    {
        if (collision.gameObject.name == "Wall")                                    //Name -> Tag�� ��ȯ
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
    {   //���� �浹�� �ı�
        if (other.gameObject.tag == "Wall")                                 
        {
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (other.gameObject.tag == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            //���Ϳ��� �������� �ְ� �������.
            other.gameObject.GetComponent<MonsterController>().Damaged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f),0.1f, 10, 1);
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            //�÷��̾�� �������� �ְ� �������
            other.gameObject.GetComponent<PlayerController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }


}
