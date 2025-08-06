using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeUI : MonoBehaviour
{
    [Header("��� Life")]
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Image lifeImage;
    [Header("���� Coin")]
    [SerializeField] private TextMeshProUGUI coinText;
    [Header("�ð� Time")]
    [SerializeField] private TextMeshProUGUI timeText;
    private float timeValue = 60;
    [Header("���� score")]
    [SerializeField] private TextMeshProUGUI scoreText;

    public void OnLifeUpdated(int lifeAmount) // ����� ����Ǿ��� �� ( ����, ���� ) �ؽ�Ʈ ui�� ����غ���
    {
        lifeText.SetText($"X{lifeAmount}");

    }
    public void OnCoinUpdated(int coinAmount) 
    {
        // coin�� ������ ������ �Ǹ�?

        coinText.SetText($"X{coinAmount}");
    }
    public void OnTimeUpdated()
    {
        timeText.SetText($"{(int)timeValue}");
    }
    public void OnScoreUpdate(int scoreAmount)
    {
        scoreText.SetText($"X{scoreAmount}");
    }

    private void Update()
    {
        timeValue -= Time.deltaTime;
        OnTimeUpdated();
    }
}
