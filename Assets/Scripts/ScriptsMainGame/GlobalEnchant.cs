using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GlobalEnchant : MonoBehaviour
{
    public GameObject Enchant_Adventure;
    public GameObject Enchant_Adventure_Object;
    public static int price_Adventure = 1;

    public GameObject Enchant_Archer;
    public GameObject Enchant_Archer_Object;
    public static int price_Archer = 1;

    public GameObject Enchant_Soldier;
    public GameObject Enchant_Soldier_Object;
    public static int price_Soldier = 1;

    public GameObject Enchant_Clem;
    public GameObject Enchant_Clem_Object;
    public static int price_Clem = 1;

    public GameObject Enchant_Heroe;
    public GameObject Enchant_Heroe_Object;
    public static int price_Heroe = 1;

    double show_price;
    private Color colOr = new Color(200, 200, 200);
    void Update()
    {
        show_price = price_Adventure;
        Enchant_Adventure.GetComponent<Text>().text = "Valor mejora: " + show_price;
       

        show_price = price_Archer;
        Enchant_Archer.GetComponent<Text>().text = "Valor mejora: " + show_price;
        

        show_price = price_Soldier;
        Enchant_Soldier.GetComponent<Text>().text = "Valor mejora: " + show_price;
        

        show_price = price_Clem;
        Enchant_Clem.GetComponent<Text>().text = "Valor mejora: " + show_price;
        

        show_price = price_Heroe;
        Enchant_Heroe.GetComponent<Text>().text = "Valor mejora: " + show_price;

        if (PurchaseLog.activated_Adventure == true)
        {
            if (GlobalCash.CashCount >= price_Adventure)
            {
                Enchant_Adventure_Object.GetComponent<Image>().color = Color.green;
                Enchant_Adventure_Object.GetComponent<Button>().interactable = true;
            }

            if (GlobalCash.CashCount < price_Adventure)
            {
                Enchant_Adventure_Object.GetComponent<Image>().color = colOr;
                Enchant_Adventure_Object.GetComponent<Button>().interactable = false;

            }
        }

        if (PurchaseLog.activated_Archer == true)
        {
            if (GlobalCash.CashCount >= price_Archer)
            {
                Enchant_Archer_Object.GetComponent<Image>().color = Color.green;
                Enchant_Archer_Object.GetComponent<Button>().interactable = true;
            }

            if (GlobalCash.CashCount < price_Archer)
            {
                Enchant_Archer_Object.GetComponent<Image>().color = colOr;
                Enchant_Archer_Object.GetComponent<Button>().interactable = false;

            }
        }

        if (PurchaseLog.activated_soldier == true)
        {
            if (GlobalCash.CashCount >= price_Soldier)
            {
                Enchant_Soldier_Object.GetComponent<Image>().color = Color.green;
                Enchant_Soldier_Object.GetComponent<Button>().interactable = true;
            }

            if (GlobalCash.CashCount < price_Soldier)
            {
                Enchant_Soldier_Object.GetComponent<Image>().color = colOr;
                Enchant_Soldier_Object.GetComponent<Button>().interactable = false;

            }
        }

        if (PurchaseLog.activated_Clem == true)
        {
            if (GlobalCash.CashCount >= price_Clem)
            {
                Enchant_Clem_Object.GetComponent<Image>().color = Color.green;
                Enchant_Clem_Object.GetComponent<Button>().interactable = true;
            }

            if (GlobalCash.CashCount < price_Clem)
            {
                Enchant_Clem_Object.GetComponent<Image>().color = colOr;
                Enchant_Clem_Object.GetComponent<Button>().interactable = false;

            }
        }




    }

    public void enchant_Adventure()
    {
      
        if (GlobalCash.CashCount >= price_Adventure && PurchaseLog.activated_Adventure==true)
        {

            autoDamage_Adventure.damage += 1;
            GlobalCash.CashCount -= price_Adventure;

           // int calculo = price_Adventure * 2;
           // price_Adventure = Math.Truncate(calculo); //redondea el decimal
            price_Adventure *= 2;

        }
    }

    public void enchant_Archer()
    {

        if (GlobalCash.CashCount >= price_Archer)
        {

            autoDamage_Archer.damage += 2;
            GlobalCash.CashCount -= price_Archer;

            //double calculo = price_Archer * 2f;
            //price_Archer = Math.Truncate(calculo); //redondea el decimal
            price_Archer *= 2;
        }
    }

    public void enchant_Soldier()
    {

        if (GlobalCash.CashCount >= price_Soldier)
        {

            autoDamage_Archer.damage += 10;
            GlobalCash.CashCount -= price_Soldier;

            //double calculo = price_Soldier * 2f;
            // price_Soldier = Math.Truncate(calculo); //redondea el decimal
            price_Soldier *= 2;

        }
    }

    public void enchant_Clem()
    {

        if (GlobalCash.CashCount >= price_Clem)
        {

            autoDamage_Archer.damage += 200;
            GlobalCash.CashCount -= price_Clem;

            //double calculo = price_Archer * 2f;
            //GlobalEnchant.price_Clem = Math.Truncate(calculo); //redondea el decimal
            price_Clem *= 2;

        }
    }

    public void enchant_Heroe()
    {

        if (GlobalCash.CashCount >= price_Heroe)
        {

           
            GlobalCash.CashCount -= price_Heroe;
            statsHero.damagePerClick += 1;
            //ouble calculo = price_Heroe * 2f;
            //ice_Heroe = Math.Truncate(calculo); //redondea el decimal
            price_Heroe *= 2;


        }
    }
}
