using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// transform, Sprite Renderer, Head 3개의 컴포넌트가 존재

// 유니티에서는 모든 MonoBehavier 상속 하는 클래스가 transform 컴포넌트를 가지고 있다.

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
        // 자기자신으로부터 자식을 검색해서 가장 먼저 발견한 컴포넌트를 반환한다.

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
