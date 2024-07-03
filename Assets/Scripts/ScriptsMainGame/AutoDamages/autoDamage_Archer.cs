using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDamage_Archer : MonoBehaviour
{
    public bool DamageEnemy = false;
    public static int damage = 10;

    // Update is called once per frame
    void Update()
    {
        if(DamageEnemy == false)
        {
            DamageEnemy = true;
            StartCoroutine(Damage_The_Enemy());
        }
    }


    IEnumerator Damage_The_Enemy()
    {

        LifeEnemies.lifeRemaing -= damage;     
        yield return new WaitForSeconds(1);
        DamageEnemy = false;
    }

}
