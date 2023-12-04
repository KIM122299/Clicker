using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    public float Damage = 1.0f; // 클릭시 데미지
    public float MaxMonHP = 10.0f; //몬스터 초기 HP
    public float NowMonHP; // 몬스터 현재 HP
    private Image Mon_HPbar; //몬스터 HP바

    public int Gold; // 골드
    public int Add_Gold = 1; //골드 수입

    public TMP_Text GoldText; //골드 수 표시 텍스트
    // Start is called before the first frame update
    void Start()
    {
        Mon_HPbar = GameObject.FindGameObjectWithTag("MON_HPBAR")?.GetComponent<Image>(); // 몬스터 HP바 연결
        NowMonHP = MaxMonHP;
        Monster_HPbar();
    }

    // Update is called once per frame
    void Update()
    {
        GoldText.text = $"GOLD : <color=#ff0000>{Gold:#,##0} </color>"; // 골드 표시
        if (Input.GetMouseButtonDown(0))
        {
            NowMonHP -= Damage; // 클릭시 몬스터 HP감소
            
        }
        Monster_HPbar();
        if(NowMonHP <= 0) //몬스터 사망시
        {
            MaxMonHP += 2; // 몬스터 체력 증가
            NowMonHP = MaxMonHP; // 몬스터 체력 초기화
            Gold += Add_Gold; // 골드증가
            Add_Gold++; // 골드 수입 증가
        }
    }
    

    void Monster_HPbar() //몬스터바 줄어들기
    {
        Mon_HPbar.fillAmount = NowMonHP/MaxMonHP;
    }
}
