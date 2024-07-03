using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPurchase : MonoBehaviour

{

    public static bool turnOffButton_Adventure = false;
    public GameObject fakeButton_Adventure;
    public GameObject realButton_Adventure;

    public static bool turnOffButton_Archer = false;
    public GameObject fakeButton_Archer;
    public GameObject realButton_Archer;

    public static bool turnOffButton_Soldier = false;
    public GameObject fakeButton_Soldier;
    public GameObject realButton_Soldier;

    public static bool turnOffButton_Clem = false;
    public GameObject fakeButton_Clem;
    public GameObject realButton_Clem;

    public static bool turnOffButton_Heroe = false;
    public static double heroe_Value = GlobalEnchant.price_Heroe;
    public GameObject fakeButton_Heroe;
    public GameObject realButton_Heroe;

    void Update()
    {
        
        //Adventure
        if (GlobalCash.CashCount >= PurchaseLog.precio_Adventure)
        {
            fakeButton_Adventure.SetActive(false);
            realButton_Adventure.SetActive(true);
        }

        if (GlobalCash.CashCount < PurchaseLog.precio_Adventure)
        {
            fakeButton_Adventure.SetActive(true);
            realButton_Adventure.SetActive(false);
        }

        if (turnOffButton_Adventure == true)
        {
;
            realButton_Adventure.SetActive(false);
            fakeButton_Adventure.SetActive(true);
            turnOffButton_Adventure = false;
        }
        //Archer
        if (GlobalCash.CashCount >= PurchaseLog.precio_Archer)
        {
            fakeButton_Archer.SetActive(false);
            realButton_Archer.SetActive(true);
        }

        if (GlobalCash.CashCount < PurchaseLog.precio_Archer)
        {
            fakeButton_Archer.SetActive(true);
            realButton_Archer.SetActive(false);
        }

        if (turnOffButton_Archer == true)
        {
            realButton_Archer.SetActive(false);
            fakeButton_Archer.SetActive(true);
            turnOffButton_Archer = false;
        }

        //Soldier
        if (GlobalCash.CashCount >= PurchaseLog.precio_Soldier)
        {
            fakeButton_Soldier.SetActive(false);
            realButton_Soldier.SetActive(true);
        }

        if (GlobalCash.CashCount < PurchaseLog.precio_Soldier)
        {
            fakeButton_Soldier.SetActive(true);
            realButton_Soldier.SetActive(false);
        }

        if (turnOffButton_Soldier == true)
        {
            realButton_Soldier.SetActive(false);
            fakeButton_Soldier.SetActive(true);
            turnOffButton_Soldier = false;
        }


        //Clem
        if (GlobalCash.CashCount >= PurchaseLog.precio_Clem)
        {
            fakeButton_Clem.SetActive(false);
            realButton_Clem.SetActive(true);
        }

        if (GlobalCash.CashCount < PurchaseLog.precio_Clem)
        {
            fakeButton_Clem.SetActive(true);
            realButton_Clem.SetActive(false);
        }

        if (turnOffButton_Clem == true)
        {
            realButton_Clem.SetActive(false);
            fakeButton_Clem.SetActive(true);
            turnOffButton_Clem = false;
        }

      

    }
}
