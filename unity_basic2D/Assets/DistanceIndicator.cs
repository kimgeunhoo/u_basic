using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceIndicator : MonoBehaviour
{
    [Header("�÷��̾�� ��ǥ ������ �����ϼ���")]
    [SerializeField] private Transform player;
    [SerializeField] private Transform target;
    [SerializeField] private Slider playerSlider;
    [Header("Enemy Slider")]
    [SerializeField] private Transform enemy;
    [SerializeField] private Slider enemySlider;

    private float StartX;
    private float StartEnemyX;

    private void Start()
    {
        StartX = player.transform.position.x * -1;
        StartEnemyX = enemy.transform.position.x * -1;
    }

    public void SetPlayerValue(float value)
    {
        playerSlider.value = value;
    }

    public void SetEnemyValue(float value)
    {
        enemySlider.value = value;
    }

    private void Update()
    {
        float playerX = player.position.x + StartX;
        //float playerY = player.position.y;
        float targetX = target.position.x + StartX;
        float enemyX = enemy.position.x + StartEnemyX;

        float sliderValue = playerX / targetX;
        SetPlayerValue(sliderValue);

        float enemySliderValue = enemyX / targetX;
        SetEnemyValue(enemySliderValue);
    }
}
