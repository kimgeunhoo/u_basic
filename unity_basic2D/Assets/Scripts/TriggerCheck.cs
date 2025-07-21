using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // Collider2D* 
    {
        if (collision.CompareTag("Enemy")) // Tag �̸��� Enemy�϶��� �Ʒ� �ڵ� ����
        {
            // 1. �浹 ����� �ı���Ű��
            Destroy(collision.gameObject);
            // 2. �浹�� �ڱ� �ڽ��� �ı���Ű��
            //Destroy(gameObject); 
        }

        // ���ǹ� �ϳ� ����
        // Tag�� Player�� �� �����ϴ� �ڵ�

        if (collision.CompareTag("Player")) // else if�� ������ ������ ������, ������� ������ �ִ�
        {
            Debug.Log("�浹�� ������Ʈ�� �̸� : " + collision.gameObject.name);
        }



    }

}
