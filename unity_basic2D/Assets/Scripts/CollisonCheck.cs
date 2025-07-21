using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� : Tag �̿��ؼ� ������ ���ӿ�����Ʈ�� ���� �ڵ带 �����Ҽ� �ֵ��� ����

public class CollisonCheck : MonoBehaviour
{
    // ��Ͽ� ���� ����
    public bool isLava = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "�� �浹��");
            Debug.Log("��Ͽ� ���� ����."); 
            isLava = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "�� �浹 ���¿��� ���");
            Debug.Log("��Ͽ� ������ ���� ����."); 
            isLava = false;
        }
    }

}
