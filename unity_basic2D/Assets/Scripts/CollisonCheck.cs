using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 도전과제 : Tag 이용해서 선택한 게임오브젝트만 다음 코드를 실행할수 있도록 변경

public class CollisonCheck : MonoBehaviour
{
    // 용암에 들어온 상태
    public bool isLava = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌함");
            Debug.Log("용암에 빠진 상태."); 
            isLava = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌 상태에서 벗어남");
            Debug.Log("용암에 빠지지 않은 상태."); 
            isLava = false;
        }
    }

}
