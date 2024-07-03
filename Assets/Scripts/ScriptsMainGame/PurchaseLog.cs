using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoDamage_Adventure;
    public GameObject adventure_Object;
    public Button button_Adventure;
    public Button button_Adventure_Fake;

    public static int precio_Adventure = 20;
    public static bool activated_Adventure = false;

    public GameObject autoDamage_Archer;
    public GameObject archer_Object;
    public Button button_Archer;
    public Button button_Archer_Fake;
    public static int precio_Archer = 50;
    public static bool activated_Archer = false;


    public GameObject autoDamage_Soldier;
    public GameObject soldier_Object;
    public Button button_Soldier;
    public Button button_Soldier_Fake;
    public static int precio_Soldier = 150;
    public static bool activated_soldier = false;


    public GameObject autoDamage_Clem;
    public GameObject clem_Object;
    public Button button_clem;
    public Button button_clem_Fake;
    public static int precio_Clem = 1000;
    public static bool activated_Clem = false;



    public void StartAutoDamage_Adventure()
    {
       
        if (GlobalCash.CashCount >= precio_Adventure)
        {
           
            GlobalCash.CashCount -= precio_Adventure;
            button_Adventure.interactable=false;
            button_Adventure_Fake.interactable=false;
            activated_Adventure = true; //Esto permite que se pueda mejorar

            autoDamage_Adventure.SetActive(true);
            adventure_Object.SetActive(true);
           
        }

    }


    public void StartAutoDamage_Archer()
    {

        if (GlobalCash.CashCount >= precio_Archer)
        {
            button_Archer.interactable = false;
            button_Archer_Fake.interactable = false;
            GlobalCash.CashCount -= precio_Archer;
            activated_Archer = true;

            autoDamage_Archer.SetActive(true);
            archer_Object.SetActive(true);

        }

    }


    public void StartAutoDamage_Soldier()
    {

        if (GlobalCash.CashCount >= precio_Soldier)
        {
            button_Soldier.interactable = false;
            button_Soldier_Fake.interactable = false;
            GlobalCash.CashCount -= precio_Soldier;
            activated_soldier = true;

            autoDamage_Soldier.SetActive(true);
            soldier_Object.SetActive(true);

        }

    }

    public void StartAutoDamage_Clem()
    {

        if (GlobalCash.CashCount >= precio_Clem)
        {
            button_clem.interactable = false;
            button_clem_Fake.interactable = false;
            GlobalCash.CashCount -= precio_Clem;
            activated_Clem = true;

            autoDamage_Clem.SetActive(true);
            clem_Object.SetActive(true);

        }

    }

}
