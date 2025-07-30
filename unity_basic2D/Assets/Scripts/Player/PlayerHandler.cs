using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    // ��� ����
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float movespeed = 5f;
    [SerializeField] private float jumppower = 5f;

    [SerializeField] private KeyCode JumpKey = KeyCode.Space;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float grondDistance = 1.2f;

    private PlayerAnimatorController playerAnimatorController;

    private float horizontal;

    // Awake �Լ�
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }

    // start �Լ�
    private void Start()
    {
        Setup();

    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }

    // Update �Լ�
    private void Update()
    {
        // �ڵ带 �ۼ��� �Ŀ� �Լ��� ���� �׽�Ʈ�� �ϰ� ���� ��
        // �ڵ尡 �ϼ��� �Ǹ� �Լ��� ����

        // 1. �÷��̾��� �Է��� �޾ƾ� �Ѵ�. A, D // ȭ��ǥ <- . -> x ��ǥ ����
        // 2. rigidbody.velocity �����ؼ� �̵��� �����Ѵ�.
       

        // horizontal �� �̿��ؼ� vector2 �� ����
        // ��� ������ �̵� �ӵ� �����ϳ� �߰� vector�� ���� ũ�⿡ �ӵ��� ���� ������ �̵��ϵ��� �ڵ� �ۼ�
        // moveSpeed

        Move();
        Jump(); 

    }

    private void Jump()
    {
        // ���� ����
        // ���� ����

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

        // playerAnimatorController.PlayBoolAnimation("IsMove", true);

        horizontal = Input.GetAxisRaw("Horizontal");

        //if(horizontal == 0)
        //{
        //    playerAnimatorController.PlayerIdleAnimation();
        //} else
        //{
        //    playerAnimatorController.PlayerMoveAnimation();
        //}

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            horizontal *= 0.5f;  
        }

        playerAnimatorController.PlayFloatAnimation("Speed", Math.Abs(horizontal)); // -1, 0, 1

        // �ִ� �ӵ� ������ �����, ���� �ӵ��� �̵� ������ ���ؼ� �� ���� 0 ~ 1������ ��ȯ�ǰ� ����� �ڵ� ����

        // float maxSpeed
        // float runSpeed

        rigidbody2D.velocity = new Vector2(horizontal * movespeed, rigidbody2D.velocity.y);

    }
}
