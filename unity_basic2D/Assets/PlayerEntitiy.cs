using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntitiy : MonoBehaviour
{
    [SerializeField] RuntimeUI runtimeUI;
    [Header("Life")]
    [SerializeField] int currentLife;
    [SerializeField] int maxLife = 10;
    [Header("Coin")]
    [SerializeField] int currentCoin;
    [SerializeField] int maxCoinForLife = 100;
    [Header("Score")]
    [SerializeField] int currentScore;

    // 게임 시작 시 현재 목숨을 최대 목숨으로 시작
    // or 절반으로 시작

    private void Start()
    {
        currentLife = maxLife / 2;
        currentCoin = 0;
        currentScore = 0;
        OnLifeUpdated(0);
        OnCoinUpdated(currentCoin);
        OnScoreUpdated(currentScore);
    }

    public void OnLifeUpdated(int amount)
    {
        currentLife += amount;

        if (currentLife > maxLife) 
        {
            currentLife = maxLife;
        }

        //RuntimeUI.LifeUpdate 실행
       runtimeUI.OnLifeUpdated(currentLife);
    }


    public void OnCoinUpdated(int amount) 
    {
        currentCoin += amount;

        if (currentCoin >= maxCoinForLife) 
        {
            currentCoin -= maxCoinForLife;
            OnLifeUpdated(1);
        }

        if (currentCoin < 0) 
        { 
            currentCoin = 0;
        }
        runtimeUI.OnCoinUpdated(currentCoin);
    }

    public void OnScoreUpdated(int amount)
    {
        currentScore += amount * 100;
        runtimeUI.OnScoreUpdate(currentScore);
    }

    public bool IsPlayerDeath()
    {
        return currentLife <= 0;
    }

}
