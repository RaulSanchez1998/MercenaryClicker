using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBoss : MonoBehaviour
{
    public GameObject gifBossLive;
    public GameObject gifBossDead;
    public bool activo=false;
    
    public void matarBoss()
    {
        if (activo == false)
        {
            gifBossLive.SetActive(false);
            gifBossDead.SetActive(true);
            activo = true;
        }
       
    }

   

}
