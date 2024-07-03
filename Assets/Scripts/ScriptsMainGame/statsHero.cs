using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsHero : MonoBehaviour
{
    public static int damagePerClick = 1;


    private void Update()
    {
        //Si tiene dinero suficiente, el boton se activará
    }
    public void enchantHero()
    {
        //Quitar dinero
        damagePerClick += 1;
    }

}
