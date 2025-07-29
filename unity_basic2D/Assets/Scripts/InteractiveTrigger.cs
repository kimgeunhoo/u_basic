using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTrigger : MonoBehaviour
{
    [SerializeField] JumpPlatform jumpPlatform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // �÷��̾�� �浹 ������ �۵�
        {
            // JumpPlatform�� �ִ� PlayTriggerAnimation �Լ� ����
            jumpPlatform.PlayTriggerAnimation("Trigger");
        }
    }
}
