using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Life = collision.GetComponent<PlayerEntitiy>(); // var는 c++ auto와 비슷
            Life.OnLifeUpdated(-1);
            // SavePoint로 돌아간다.
            

            // 남은 목숨이 0개 이하일때 활성화하기
            // 남은 목숨을 어떻게 들고오나? -> 플레이어의 게임오브젝트 안에 플레이어의 목숨을 제어하는 스크립트
            // 목숨을 제어하는 스크립트가 있다면 그 스크립트에서 목숨 빼기

            if (Life.IsPlayerDeath() == true)
            {
                GameOverPanel.SetActive(true);
            }      
        }
    }
}
