using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public GameObject saveButton;
   

    public void SaveTheGame()
    {
        //Grado de mejora
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("priceAdventure", GlobalEnchant.price_Adventure);
        PlayerPrefs.SetInt("priceArcher", GlobalEnchant.price_Archer);
        PlayerPrefs.SetInt("priceSoldier", GlobalEnchant.price_Soldier);
        PlayerPrefs.SetInt("priceClem", GlobalEnchant.price_Clem);
        PlayerPrefs.SetInt("priceHeroe", GlobalEnchant.price_Heroe);
        //----------------------------------------------------------------//

        //Mercenarios desbloqueados
        if(PurchaseLog.activated_Adventure == true)
        {
            PlayerPrefs.SetInt("AdventureUnlock", 1);
            
        }
        else
        {
            PlayerPrefs.SetInt("AdventureUnlock", 0);
        }
        
        if(PurchaseLog.activated_Archer == true)
        {
            PlayerPrefs.SetInt("ArcherUnlock", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ArcherUnlock", 0);
        }
        
        if(PurchaseLog.activated_soldier == true)
        {
            PlayerPrefs.SetInt("SoldierUnlock", 1);
        }
        else
        {
            PlayerPrefs.SetInt("SoldierUnlock", 0);
        }
        
        if(PurchaseLog.activated_Clem == true)
        {
            PlayerPrefs.SetInt("ClemUnlock", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ClemUnlock", 0);
        }

        //Daño mercenarios
        PlayerPrefs.SetInt("DamageAdventure", autoDamage_Adventure.damage);
        PlayerPrefs.SetInt("DamageArcher", autoDamage_Archer.damage);
        PlayerPrefs.SetInt("DamageSoldier", autoDamage_Soldier.damage);
        PlayerPrefs.SetInt("DamageClem", autoDamage_Clem.damage);
        PlayerPrefs.SetInt("Damageheroe", statsHero.damagePerClick);




        //Vida del enemigo
        PlayerPrefs.SetInt("LifeEnemy", LifeEnemies.lifeEnemy);
        PlayerPrefs.SetInt("DropMoney", LifeEnemies.dropMoney);
        PlayerPrefs.SetInt("ChangeEnemy", LifeEnemies.changeEnemy);


        PlayerPrefs.Save();

    }
}
