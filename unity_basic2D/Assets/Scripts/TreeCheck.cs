using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ �÷��̾ �ε����� �÷��̾ �ı��ȴ�
public class TreeCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
