using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinion : MonoBehaviour
{
    public GameObject GifBoss_Alive;
    public GameObject GifBoss_Dead;
    public GameObject GifMinion_Alive;
    public GameObject GifMinion_Dead;

    public void SpawnMin()
    {
        GifBoss_Alive.SetActive(false);
        GifBoss_Dead.SetActive(false);
        GifMinion_Alive.SetActive(true);
        GifMinion_Dead.SetActive(false);

    }

    public void SpawnBoss()
    {
        GifBoss_Alive.SetActive(true);
        GifBoss_Dead.SetActive(false);
        GifMinion_Alive.SetActive(false);
        GifMinion_Dead.SetActive(false);
    }
}
