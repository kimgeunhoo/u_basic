using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // Collider2D* 
    {
        if (collision.CompareTag("Enemy")) // Tag 이름이 Enemy일때만 아래 코드 실행
        {
            // 1. 충돌 대상을 파괴시키기
            Destroy(collision.gameObject);
            // 2. 충돌한 자기 자신을 파괴시키기
            //Destroy(gameObject); 
        }

        // 조건문 하나 생성
        // Tag가 Player일 때 실행하는 코드

        if (collision.CompareTag("Player")) // else if는 오류의 위험이 있으나, 연산상의 이점은 있다
        {
            Debug.Log("충돌한 오브젝트의 이름 : " + collision.gameObject.name);
        }



    }

}
