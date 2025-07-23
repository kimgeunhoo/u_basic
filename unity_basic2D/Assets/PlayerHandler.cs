using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    // 멤버 변수
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float movespeed = 5f;
    [SerializeField] private float jumppower = 5f;

    [SerializeField] private KeyCode JumpKey = KeyCode.Space;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float grondDistance = 1.2f;

    // Awake 함수
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // start 함수
    private void Start()
    {
        Setup();

    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }

    // Update 함수
    private void Update()
    {
        // 코드를 작성한 후에 함수로 추출 테스트를 하고 싶을 때
        // 코드가 완성이 되면 함수로 추출

        // 1. 플레이어의 입력을 받아야 한다. A, D // 화살표 <- . -> x 좌표 변경
        // 2. rigidbody.velocity 변경해서 이동을 구현한다.
       

        // horizontal 값 이용해서 vector2 값 변경
        // 멤버 변수로 이동 속도 변수하나 추가 vector의 현재 크기에 속도를 곱한 값으로 이동하도록 코드 작성
        // moveSpeed

        Move();
        Jump(); 

    }

    private void Jump()
    {
        // 점프 조건
        // 점프 구현

        if (CanJump())
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumppower);
        }

        Debug.DrawRay(transform.position, Vector3.down * grondDistance, Color.red);
    }

    private bool CanJump()
    {
        return Input.GetKeyDown(JumpKey) && GroundCheck();
    }

    private bool GroundCheck()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, grondDistance, groundLayer);
        return hit.collider != null; 
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rigidbody2D.velocity = new Vector2(horizontal * movespeed, rigidbody2D.velocity.y);

    }
}
