using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    // Animator 컴포넌트를 가져와서 실행하는 함수 만들기
    // PlayerHandler에 PlayerAnimatorController 클래스 참조할 수 있도록 연결
    // PlayerHandler에서 PlayerAnimatorController의 public으로 만들어진 애니메이터 실행 함수 호출

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
