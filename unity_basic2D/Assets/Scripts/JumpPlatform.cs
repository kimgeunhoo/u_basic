using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // 1. Animator Component를 Awake 함수에서 값을 초기화 해주기. Setup
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // 충돌 영역에 플레이어가 들어왔을 때만 이 코드를 실행   
        PlayTriggerAnimation("Trigger");
    }

    public void PlayTriggerAnimation(string paramName)
    {
        _animator.SetTrigger(paramName);
    }

 
}
