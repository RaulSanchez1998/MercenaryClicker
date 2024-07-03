using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics.Tracing;

public class LifeEnemies : MonoBehaviour
{
    public GameObject BossAlive;
    public GameObject BossDeadAnimation;
    public GameObject MinionAlive;
    public GameObject MinionDeadAnimation;

    public static int lifeEnemy = 10;
    public static int dropMoney = 5;
    public static int lifeRemaing;
    public GameObject HealthDisplay;
    public static int changeEnemy=0;

    private int counter =0;
    private int waitTime = 300;


    void Start()
    {
        lifeRemaing = lifeEnemy;
    }

    public void hitEnemy()
    {
        lifeRemaing -= statsHero.damagePerClick;
        print(statsHero.damagePerClick);
        if (lifeRemaing <= 0)
        {
            changeEnemy += 1;
            cambiarAnimation();
        }
 
    }

    private void cambiarAnimation()
    {
        BossAlive.SetActive(false);
        MinionAlive.SetActive(true);

        if (changeEnemy == 5)
        {
            MinionAlive.SetActive(false);
            BossAlive.SetActive(true);
            dropMoney += 5;
            changeEnemy = 0;

        }
    }

    IEnumerator waiter()
    {
        while (counter < waitTime)
        {
            //Increment Timer until counter >= waitTime
            counter += 1;
            Debug.Log("We have waited for: " + counter + " seconds");
            //Wait for a frame so that Unity doesn't freeze
            //Check if we want to quit this function
            
            yield return null;
        }


    }


    void Update()
    {
        HealthDisplay.GetComponent<Text>().text = lifeRemaing + "/" + lifeEnemy;

        if (lifeRemaing <= 0)
        {
            GlobalCash.CashCount += dropMoney;
            //double calculo = lifeEnemy * 1.2;
            //lifeEnemy = Math.Truncate(calculo); //redondea el decimal
            lifeEnemy *= 2;
            lifeRemaing = lifeEnemy;
            HealthDisplay.GetComponent<Text>().text = lifeRemaing + "/" + lifeEnemy;
            
        }
    }
    

}
