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
            var Life = collision.GetComponent<PlayerEntitiy>(); // var�� c++ auto�� ���
            Life.OnLifeUpdated(-1);
            // SavePoint�� ���ư���.
            

            // ���� ����� 0�� �����϶� Ȱ��ȭ�ϱ�
            // ���� ����� ��� ������? -> �÷��̾��� ���ӿ�����Ʈ �ȿ� �÷��̾��� ����� �����ϴ� ��ũ��Ʈ
            // ����� �����ϴ� ��ũ��Ʈ�� �ִٸ� �� ��ũ��Ʈ���� ��� ����

            if (Life.IsPlayerDeath() == true)
            {
                GameOverPanel.SetActive(true);
            }      
        }
    }
}
