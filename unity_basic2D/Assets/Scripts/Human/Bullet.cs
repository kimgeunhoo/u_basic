using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // �浹�� �༮�� ���� ������Ʈ���� ������ ������ �� �ִ� ������Ʈ(sprite Renderer)�� ������ �� ������ ���������� ����

            SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>();
            if (_sr != null)
            {
                _sr.color = Color.red;
                Invoke(nameof(_sr), 0.5f);
            }

            // �������Ѽ� ����
            

            // �ٸ� ��� 
            //if(collision.TryGetComponent(out SpriteRenderer sr))
            //{
            //    sr.color = Color.red;
            //}

        }

    }
    private void Reset(SpriteRenderer cr)
    {
            cr.color = Color.white;
    }

}
