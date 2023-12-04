using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    public float Damage = 1.0f; // Ŭ���� ������
    public float MaxMonHP = 10.0f; //���� �ʱ� HP
    public float NowMonHP; // ���� ���� HP
    private Image Mon_HPbar; //���� HP��

    public int Gold; // ���
    public int Add_Gold = 1; //��� ����

    public TMP_Text GoldText; //��� �� ǥ�� �ؽ�Ʈ
    // Start is called before the first frame update
    void Start()
    {
        Mon_HPbar = GameObject.FindGameObjectWithTag("MON_HPBAR")?.GetComponent<Image>(); // ���� HP�� ����
        NowMonHP = MaxMonHP;
        Monster_HPbar();
    }

    // Update is called once per frame
    void Update()
    {
        GoldText.text = $"GOLD : <color=#ff0000>{Gold:#,##0} </color>"; // ��� ǥ��
        if (Input.GetMouseButtonDown(0))
        {
            NowMonHP -= Damage; // Ŭ���� ���� HP����
            
        }
        Monster_HPbar();
        if(NowMonHP <= 0) //���� �����
        {
            MaxMonHP += 2; // ���� ü�� ����
            NowMonHP = MaxMonHP; // ���� ü�� �ʱ�ȭ
            Gold += Add_Gold; // �������
            Add_Gold++; // ��� ���� ����
        }
    }
    

    void Monster_HPbar() //���͹� �پ���
    {
        Mon_HPbar.fillAmount = NowMonHP/MaxMonHP;
    }
}
