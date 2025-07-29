using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    // Animator ������Ʈ�� �����ͼ� �����ϴ� �Լ� �����
    // PlayerHandler�� PlayerAnimatorController Ŭ���� ������ �� �ֵ��� ����
    // PlayerHandler���� PlayerAnimatorController�� public���� ������� �ִϸ����� ���� �Լ� ȣ��

    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void PlayBoolAnimation(string paramName, bool enable)
    {
        _animator.SetBool(paramName, enable);
    }

    public void PlayerMoveAnimation()
    {
        PlayBoolAnimation("IsMove", true);
        PlayBoolAnimation("IsIdle", false);
    }
    public void PlayerIdleAnimation()
    {
        PlayBoolAnimation("IsMove", false);
        PlayBoolAnimation("IsIdle", true);
    }


}
