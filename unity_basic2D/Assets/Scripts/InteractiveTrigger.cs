using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTrigger : MonoBehaviour
{
    [SerializeField] JumpPlatform jumpPlatform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 플레이어와 충돌 했을때 작동
        {
            // JumpPlatform에 있는 PlayTriggerAnimation 함수 실행
            jumpPlatform.PlayTriggerAnimation("Trigger");
        }
    }
}
