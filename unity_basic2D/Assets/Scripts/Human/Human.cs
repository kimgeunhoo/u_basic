using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// transform, Sprite Renderer, Head 3���� ������Ʈ�� ����

// ����Ƽ������ ��� MonoBehavier ��� �ϴ� Ŭ������ transform ������Ʈ�� ������ �ִ�.

public class Human : MonoBehaviour
{
    private HumanBone[] allBones;

    private Arm[] arm;
    private Body body;
    private Leg[] leg;
    private Head head;

    [SerializeField] private Color Color;
    [SerializeField] private int SortingOrder = 10;

    [SerializeField] private Color armColor;
    [SerializeField] private int armSortingOrder = 10;

    // Start is called before the first frame update
    void Start()
    {
        // �ڱ��ڽ����κ��� �ڽ��� �˻��ؼ� ���� ���� �߰��� ������Ʈ�� ��ȯ�Ѵ�.

        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentsInChildren<Arm>();
        head = GetComponentInChildren<Head>();
        body = GetComponentInChildren<Body>();
        leg = GetComponentsInChildren<Leg>();

        for(int i =0; i < allBones.Length; i++)
        {
            allBones[i].SetRenderProperty(Color, SortingOrder);
        }

        for (int i = 0; i < arm.Length; i++)
        {
            arm[i].SetRenderProperty(armColor, armSortingOrder);
        }
    }


}
