using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{

    public GameObject animAdv;
    public GameObject autoDmgAdv;
    public Button advButton;
    public Button advButton_Fake;
    
    public GameObject animArch;
    public GameObject autoDmgArch;
    public Button archButton;
    public Button archButton_Fake;

    public GameObject animSold;
    public GameObject autoDmgsold;
    public Button soldButton;
    public Button soldButton_Fake;

    public GameObject animClem;
    public GameObject autoDmgClem;
    public Button clemButton;
    public Button clemButton_Fake;

    public int savedCash;

    public int priceAdventure;
    public int priceArcher;
    public int priceSoldier;
    public int priceClem;
    public int priceHeroe;

    public  int advUnlock;
    public  int archUnlock;
    public  int soldUnlock;
    public  int clemUnlock;

    public int dmgAdventure;
    public int dmgArcher;
    public int dmgSoldier;
    public int dmgClem;
    public int dmgHeroe;

    public int lifeEnemy;
    public int dropMoney;
    public int changeEnemy;

    


    void Start()
    {
        if (mainMenuOptions.isLoading == true)
        {
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;

            priceAdventure = PlayerPrefs.GetInt("priceAdventure");
            GlobalEnchant.price_Adventure = priceAdventure;
            
            priceArcher = PlayerPrefs.GetInt("priceArcher");
            GlobalEnchant.price_Archer = priceArcher;

            priceSoldier = PlayerPrefs.GetInt("priceSoldier");
            GlobalEnchant.price_Soldier = priceSoldier;

            priceClem = PlayerPrefs.GetInt("priceClem");
            GlobalEnchant.price_Clem = priceClem;

            priceHeroe = PlayerPrefs.GetInt("priceHeroe");
            GlobalEnchant.price_Heroe = priceHeroe;

            //Mercenarios desbloqueado
            advUnlock = PlayerPrefs.GetInt("AdventureUnlock");
            if (advUnlock==1)
            {
               
                PurchaseLog.activated_Adventure = true;
                animAdv.SetActive(true);
                autoDmgAdv.SetActive(true);
                advButton.interactable=false;
                advButton_Fake.interactable = false;

            }
            else
            {
                PurchaseLog.activated_Adventure = false;
            }

            archUnlock = PlayerPrefs.GetInt("ArcherUnlock");
            if (archUnlock==1)
            {
                PurchaseLog.activated_Archer = true;
                animArch.SetActive(true);
                autoDmgArch.SetActive(true);
                archButton.interactable = false;
                archButton_Fake.interactable = false;
            }
            else
            {
                PurchaseLog.activated_Archer = false;
            }

            soldUnlock = PlayerPrefs.GetInt("SoldierUnlock");
            if (soldUnlock==1)
            {
                PurchaseLog.activated_soldier = true;
                animSold.SetActive(true);
                autoDmgsold.SetActive(true);
                soldButton.interactable = false;
                soldButton_Fake.interactable = false;
            }
            else
            {
                PurchaseLog.activated_soldier = false;
            }

            clemUnlock = PlayerPrefs.GetInt("ClemUnlock");
            if (clemUnlock==1)
            {
                PurchaseLog.activated_Clem = true;
                animClem.SetActive(true);
                autoDmgClem.SetActive(true);
                clemButton.interactable = false;
                clemButton_Fake.interactable = false;
            }
            else
            {
                PurchaseLog.activated_Clem = false;
            }



            //Daño Mercenarios

            dmgAdventure =PlayerPrefs.GetInt("DamageAdventure");
            autoDamage_Adventure.damage = dmgAdventure;

            dmgArcher = PlayerPrefs.GetInt("DamageArcher");
            autoDamage_Archer.damage = dmgArcher;

            dmgSoldier = PlayerPrefs.GetInt("DamageSoldier");
            autoDamage_Soldier.damage = dmgSoldier;

            dmgClem = PlayerPrefs.GetInt("DamageClem");
            autoDamage_Clem.damage = dmgClem;

            dmgHeroe = PlayerPrefs.GetInt("Damageheroe");
            statsHero.damagePerClick = dmgHeroe;

            //Vida enemigo
            lifeEnemy = PlayerPrefs.GetInt("LifeEnemy");
            LifeEnemies.lifeEnemy=lifeEnemy;

            dropMoney = PlayerPrefs.GetInt("DropMoney");
            LifeEnemies.dropMoney= dropMoney;

            changeEnemy = PlayerPrefs.GetInt("ChangeEnemy");
            LifeEnemies.changeEnemy = changeEnemy;




        }
        
    }
}
