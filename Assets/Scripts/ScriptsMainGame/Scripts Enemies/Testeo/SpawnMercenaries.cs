using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMercenaries : MonoBehaviour
{
    public GameObject Mercenary_Soldier;
    public GameObject Mercenary_Archer;
    public GameObject Mercenary_Adventure;
    public GameObject Mercenary_Clem;


    public void purchaseSoldier()
    {
        //Aqui se restaria el dinero
        Mercenary_Soldier.SetActive(true);
    }

    public void purchaseAdventure()
    {
        //Aqui se restaria el dinero
        Mercenary_Adventure.SetActive(true);
    }

    public void purchaseArcher()
    {
        //Aqui se restaria el dinero
        Mercenary_Archer.SetActive(true);
    }

    public void purchaseClem()
    {
        //Aqui se restaria el dinero
        Mercenary_Clem.SetActive(true);
    }





}
