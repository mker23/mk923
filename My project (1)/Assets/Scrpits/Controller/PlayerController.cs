using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6;                                             //���� �̵� ���ǽ� �����ϰ� ����
    public GameObject PlayerPivot;                                          //�þ߸� ��� ������ ������ �����ϱ� ���� ��ġ Pivot
    Camera viewCamera;                                                      //���� ī�޶� �������� ���� ī�޶� Ŭ���� ����
    Vector3 velocity;                                                       //�̵� ���� ���͸� ����
    public ProjectileController projectileController;
    

    void Start()
    {
        viewCamera = Camera.main;                                           //���� ī�޶� �������� ���ؼ� start���� ã�Ƽ� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
        //��ǻ�� ȭ�� 2D�� ���콺 ��ǥ���� ī�޶� ����� �� 3D ���������� ���콺 ��ġ ���� �������� ���ؼ�
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        
        //�÷��̾ ������ Ÿ�� ����Ʈ
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);

        //�÷��̾� �Ǻ��� ������� �ϴ� ��ǥ�� ����
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);

        //Input �� ���� ĳ���� �̵� ���͸� �����Ѵ�.
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;


    }

    private void FixedUpdate()
    {
        //����� ���͸� �÷��̾� ��Ʈ�ѷ��� �ִ� Rigidbody�� �����ؼ� �̵� ���͸� �����ð� Time ��ŭ �̵������ִ� ����
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
    }
}

     