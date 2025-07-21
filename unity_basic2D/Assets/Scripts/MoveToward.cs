using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    [SerializeField] private Transform target;

    // moveSpeed Float 타입의 변수를 선언 해서 이동속도에 곱해준다.
    [SerializeField] private Vector3 startVector;
    [SerializeField] private float moveSpeed = 1.5f;

    // 변수에 데이터를 넣어줘야 한다.
    // 데이터의 초기화가 필요하다.

    // Start is called before the first frame update
    void Start()
    {   

        transform.position
            = transform.position + startVector;

        // 이동하는 방향만 표현해준다. (벡터의 정규화)
        startVector = startVector.normalized;

        //              타겟 방향           오브젝트 위치
        startVector = (target.position - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    { 
        transform.position += startVector * Time.deltaTime * moveSpeed;
        startVector = (target.position - transform.position).normalized;
    }

    
}
