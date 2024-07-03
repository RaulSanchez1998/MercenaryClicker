using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMinion : MonoBehaviour
{
    public GameObject gifMinionLive;
    public GameObject gifMinionDead;
    public bool activo = false;

    public void matarMinion()
    {
        if (activo == false)
        {
            gifMinionLive.SetActive(false);
            gifMinionDead.SetActive(true);
           
        }

    }
}
