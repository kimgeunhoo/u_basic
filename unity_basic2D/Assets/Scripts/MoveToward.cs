using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    [SerializeField] private Transform target;

    // moveSpeed Float Ÿ���� ������ ���� �ؼ� �̵��ӵ��� �����ش�.
    [SerializeField] private Vector3 startVector;
    [SerializeField] private float moveSpeed = 1.5f;

    // ������ �����͸� �־���� �Ѵ�.
    // �������� �ʱ�ȭ�� �ʿ��ϴ�.

    // Start is called before the first frame update
    void Start()
    {   

        transform.position
            = transform.position + startVector;

        // �̵��ϴ� ���⸸ ǥ�����ش�. (������ ����ȭ)
        startVector = startVector.normalized;

        //              Ÿ�� ����           ������Ʈ ��ġ
        startVector = (target.position - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    { 
        transform.position += startVector * Time.deltaTime * moveSpeed;
        startVector = (target.position - transform.position).normalized;
    }

    
}
