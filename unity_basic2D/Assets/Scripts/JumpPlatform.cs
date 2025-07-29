using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // 1. Animator Component�� Awake �Լ����� ���� �ʱ�ȭ ���ֱ�. Setup
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // �浹 ������ �÷��̾ ������ ���� �� �ڵ带 ����   
        PlayTriggerAnimation("Trigger");
    }

    public void PlayTriggerAnimation(string paramName)
    {
        _animator.SetTrigger(paramName);
    }

 
}
