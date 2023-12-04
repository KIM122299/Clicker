using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    //public Button Player_Button;
    public GameObject Player_Menu;
    public GameObject Partner_Menu;
    public GameObject Equip_Menu;

    private bool PlayerMenu_state;
    private bool PartnerMenu_state;
    private bool EquipMenu_state;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMenu_state = false;
        PartnerMenu_state = false;
        EquipMenu_state = false;
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    public void Player_OnClick() 
    {
        if (PlayerMenu_state)
        {
            Player_Menu.SetActive(false);
   
            PlayerMenu_state = false;
        }
        else
        {
            Player_Menu.SetActive(true);
            
            PlayerMenu_state = true;

            Partner_Menu.SetActive(false);
            Equip_Menu.SetActive(false);

            PartnerMenu_state = false;
            EquipMenu_state = false;
        }

    }
    public void Partner_OnClick()
    {
        if (PartnerMenu_state)
        {
            Partner_Menu.SetActive(false);
           

            PartnerMenu_state = false;
        }
        else
        {
            Partner_Menu.SetActive(true);
            PartnerMenu_state = true;

            Player_Menu.SetActive(false);
            Equip_Menu.SetActive(false);

            EquipMenu_state = false;
            PlayerMenu_state = false;
        }

    }
    public void Equip_OnClick()
    {
        if (EquipMenu_state)
        {
            Equip_Menu.SetActive(false);
            
            EquipMenu_state = false;
        }
        else
        {
            Equip_Menu.SetActive(true);
            EquipMenu_state = true;

            Partner_Menu.SetActive(false);
            Player_Menu.SetActive(false);

            PlayerMenu_state = false;
            PartnerMenu_state = false;
        }
        
    }



}
