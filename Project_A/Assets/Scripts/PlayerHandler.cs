using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float movespeed = 5f;
    [SerializeField] private float jumppower = 5f;
    [SerializeField] private int jumpStack = 0;

    [SerializeField] private KeyCode jumpKey = KeyCode.Space;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.freezeRotation = true;
    }



    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 moveVector2 = new Vector2(horizontal * movespeed, _rigidbody2D.velocity.y);
        _rigidbody2D.velocity = moveVector2;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(jumpKey) /*&& CheckGround*/)
        {
            Vector2 jumpVector2 = new Vector2(_rigidbody2D.velocity.x, jumppower);
            _rigidbody2D.velocity = jumpVector2;
            jumpStack++;
        } 
    }

    //private bool CheckGround()
    //{
        
    //}
}
